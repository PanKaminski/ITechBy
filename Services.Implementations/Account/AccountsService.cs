using Domain.Common.Enums;
using Domain.Exceptions;
using Domain.Models.Account;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Services.Abstractions.Account;
using Services.Abstractions.Common;
using Services.Abstractions.Data;
using Services.Abstractions.Data.Account;
using Services.Abstractions.Data.Repositories.LoadOptions;
using Services.Abstractions.Extensions;
using Services.Abstractions.RequestModels.Account;
using System.Data;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Services.Implementations.Account
{
    public class AccountsService : IAccountsService
    {
        private const int PswHashIterationsCount = 100;
        private const int ResetTokenExpireDays = 1;

        private readonly IUnitOfWork unitOfWork;
        private readonly ITokenService tokenService;

        public AccountsService(IUnitOfWork unitOfWork, ITokenService tokenService)
        {
            this.unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            this.tokenService = tokenService ?? throw new ArgumentNullException(nameof(tokenService));
        }

        public AuthenticateResponseModel Login(string email, string password)
        {
            var loadOptions = new List<AccountLoadOptions> { AccountLoadOptions.WithRoles, AccountLoadOptions.WithRefreshTokens };
            var userDto = unitOfWork.UsersRepository.Find(email, false, loadOptions);

            if (userDto is { VerificationTime: null })
            {
                throw new ITechCoreException(ExceptionCode.UserIsNotVerified, $"User {email} is not verified", email);
            }

            if (HashPassword(password, userDto.PasswordSalt) != userDto.PasswordHash)
            {
                throw new ITechCoreException(ExceptionCode.IncorrectPassword, "Password is incorrect");
            }

            var jwt = GenerateGwt(userDto);
            userDto.RefreshToken = tokenService.ResetRefreshToken(userDto.Id).ToEntity();

            unitOfWork.Commit();

            return CreateAccountResponse(userDto, jwt);
        }

        public async Task<User> RegisterAsync(RegisterRequestModel requestModel)
        {
            ArgumentNullException.ThrowIfNull(nameof(requestModel));

            if (unitOfWork.UsersRepository.Exists(requestModel.email))
            {
                throw new ITechCoreException(ExceptionCode.SuchUserAlreadyExists, "User with such code already exists");
            }

            var user = await CreateUserAsync(requestModel.firstName, requestModel.lastName, requestModel.email,
                 requestModel.password, requestModel.gender);
            var userEntity = user.ToEntity();
            userEntity.Roles = unitOfWork.RolesRepository.Get( r => user.Roles.Contains(r.Type), true).ToList();

            unitOfWork.UsersRepository.Create(userEntity);

            return user;
        }

        public bool VerifyEmail(string token)
        {
            ArgumentException.ThrowIfNullOrEmpty(token);
            var account = unitOfWork.UsersRepository.FirstOrDefault(u => u.VerificationToken == token, true);

            if (account is null)
            {
                return false;
            }

            account.Status = AccountStatus.Approved;
            account.VerificationTime = DateTime.UtcNow;
            account.VerificationToken = null;

            unitOfWork.Commit();

            return true;
        }

        public async Task<User> ForgotPasswordAsync(string email, string origin)
        {
            var accountDto = await unitOfWork.UsersRepository.FirstOrDefaultAsync(u => u.Email == email, true);

            if (accountDto is null)
            {
                throw new ITechCoreException(ExceptionCode.UserDoesntExist);
            }

            accountDto.ResetToken = await GenerateSpecificUserTokenAsync(u => u.ResetToken);
            accountDto.ResetTokenExpires = DateTime.UtcNow.AddDays(ResetTokenExpireDays);
            accountDto.Status = AccountStatus.Draft;

            return accountDto.ToModel();
        }

        public void ResetPassword(string token, string password)
        {
            var account = GetUserByResetToken(token);

            if (account is null) 
            {
                throw new ITechCoreException(ExceptionCode.UserDoesntExist);
            }

            (account.PasswordHash, account.PasswordSalt) = HashPassword(password);
            account.ResetToken = null;
            account.ResetTokenExpires = null;
            account.Status = AccountStatus.Approved;
        }

        public void ValidateResetToken(string token)
        {
            if (GetUserByResetToken(token) is null)
            {
                throw new ITechCoreException(ExceptionCode.InvalidResetToken, "Invalid reset token");
            }
        }

        private UserEntity GetUserByResetToken(string token) =>
            unitOfWork.UsersRepository.FirstOrDefault(u => u.ResetToken == token
            && u.ResetTokenExpires < DateTime.UtcNow, false);

        public async Task<AuthenticateResponseModel> RefreshTokenAsync(string refreshTokenSource)
        {
            var loadOptions = new List<AccountLoadOptions> { AccountLoadOptions.WithRoles, AccountLoadOptions.WithRefreshTokens };
            var userDto = await unitOfWork.UsersRepository.FirstOrDefaultAsync(u => u.RefreshToken?.Source == refreshTokenSource, false, loadOptions);

            if (userDto is null)
            {
                throw new ITechCoreException(ExceptionCode.UserDoesntExist, "User doesn't exist");
            }

            if (userDto.RefreshToken?.Source is null)
            {
                throw new ITechCoreException(ExceptionCode.InvalidRefreshToken, "Invalid refresh token");
            }

            userDto.RefreshToken = tokenService.ResetRefreshToken(userDto.Id).ToEntity();
            unitOfWork.Commit();

            var jwtToken = GenerateGwt(userDto);

            return CreateAccountResponse(userDto, jwtToken);
        }

        private async Task<User> CreateUserAsync(string firstName, string lastName, string email, string password, GenderType gender)
        {
            var pswHashResult = HashPassword(password);
            var role = unitOfWork.UsersRepository.HasAdminUser() ? RoleType.User : RoleType.Admin;
            var user = new User
            {
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                Gender = gender,
                PasswordHash = pswHashResult.hash,
                PasswordSalt = pswHashResult.salt,
                Status = AccountStatus.Draft,
                Roles = new List<RoleType> { role },
                VerificationToken = await GenerateSpecificUserTokenAsync(u => u.VerificationToken),
            };

            return user;
        }

        private (string hash, string salt) HashPassword(string password)
        {
            var salt = Convert.ToHexString(RandomNumberGenerator.GetBytes(64));

            return (HashPassword(password, salt), salt);
        }

        private string HashPassword(string password, string salt) => Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: Encoding.UTF8.GetBytes(salt),
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: PswHashIterationsCount,
            numBytesRequested: 64));

        private string GenerateGwt(UserEntity userDto)
        {
            var claims = new Claim[]
{
                new Claim("Id", userDto.Id.ToString()),
                new Claim(ClaimTypes.Role, string.Join(',', userDto.Roles.Select(r => Enum.GetName(r.Type))))
};
            return tokenService.GenerateJwt(claims);
        }

        private AuthenticateResponseModel CreateAccountResponse(UserEntity account, string jwt)
        {
            var viewModel = new AuthenticateResponseModel
            {
                Id = account.Id,
                FirstName = account.FirstName,
                LastName = account.LastName,
                Email = account.Email,
                Roles = account.Roles.Select(r => r.Type),
                JwtToken = jwt,
                RefreshToken = account.RefreshToken?.Source,
            };

            return viewModel;
        }

        private async Task<string> GenerateSpecificUserTokenAsync(Func<UserEntity, string> tokenFieldMapper)
        {
            var users = (await unitOfWork.UsersRepository.GetAllInChunkAsync(false)).ToList();
            string token = null;

            do
            {
                token = Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
            } while (users.Any(u => tokenFieldMapper(u) == token));

            return token;
        }
    }
}