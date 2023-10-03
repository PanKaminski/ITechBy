using Domain.Models.Account;
using Services.Abstractions.Account;
using Services.Abstractions.Common;
using Services.Abstractions.Common.OperationResult;
using Services.Abstractions.Data;
using Services.Abstractions.RequestModels.Account;

namespace Presentation.Authentication
{
    public class AccountToolService
    {
        private readonly IEmailService emailService;
        private readonly IAccountsService accountsService;
        private readonly IUnitOfWork unitOfWork;

        public AccountToolService(IUnitOfWork unitOfWork, IEmailService emailService, IAccountsService accountsService)
        {
            this.unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            this.emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
            this.accountsService = accountsService ?? throw new ArgumentNullException(nameof(accountsService));
        }

        public async Task<ServerOperationResult> RegisterAsync(RegisterRequestModel registerModel)
        {
            ArgumentNullException.ThrowIfNull(nameof(registerModel));

            var newUser = await accountsService.RegisterAsync(registerModel);
            await emailService.SendAsync(CreateEmailVerificationMessage(newUser, registerModel.origin));
            await unitOfWork.CommitAsync();

            return new ServerOperationResult(ResultCode.Success, ServerMessageCode.RegistrationSuccess);
        }

        public AuthenticateResponseModel Login(string email, string password) => accountsService.Login(email, password);
        
        public Task<AuthenticateResponseModel> RefreshTokenAsync(string refreshTokenSource) => accountsService.RefreshTokenAsync(refreshTokenSource);

        public ServerOperationResult VerifyEmail(string email)
        {
            if (!accountsService.VerifyEmail(email))
            {
                return new ServerOperationResult(ResultCode.Failed, ServerMessageCode.VerificationFailed, "Verification failed");
            }

            unitOfWork.Commit();
            return new ServerOperationResult(ResultCode.Success, ServerMessageCode.EmailVerificationSuccess);
        }

        public void ValidateResetToken(string token) => accountsService.ValidateResetToken(token);

        public async Task<ServerOperationResult> ForgotPasswordAsync(string email, string origin)
        {
            try
            {
                var user = await accountsService.ForgotPasswordAsync(email, origin);

                await emailService.SendAsync(CreatePasswordResetMessage(user, origin));

                await unitOfWork.CommitAsync();

                return new ServerOperationResult(ResultCode.Success, ServerMessageCode.CheckEmailForPswResetInstructions);

            }
            catch (Exception)
            {
                return new ServerOperationResult(ResultCode.Failed, ServerMessageCode.InvalidUser);
            }
        }

        public ServerOperationResult ResetPassword(string token, string password)
        {
            try
            {
                accountsService.ResetPassword(token, password);
                unitOfWork.Commit();
                return new ServerOperationResult(ResultCode.Success, ServerMessageCode.ResetPasswordSuccess);
            }
            catch (Exception)
            {
                return new ServerOperationResult(ResultCode.Failed, ServerMessageCode.ResetPasswordFailed);
            }
        }

        private EmailMessage CreateEmailVerificationMessage(User user, string origin)
        {
            var message = "<h1>Thank you for registering!</h1>\n";

            if (!string.IsNullOrEmpty(origin))
            {
                var verifyUrl = $"{origin}/verify-email?token={user.VerificationToken}";

                message += $@"<p>Please follow the link to verify your email address:</p>
                            <p><a href=""{verifyUrl}"">{verifyUrl}</a></p>";
            }
            else
            {
                message += $@"<p>Please insert this token to verify your email address with the <code>/accounts/verify-email</code> api route:</p>
                            <p><code>{user.VerificationToken}</code></p>";
            }

            var targetName = $"{user.FirstName} {user.LastName}" ?? string.Empty;

            return new EmailMessage("ItechBy - Verify Email", message, new EmailAddress(user.Email, targetName));
        }

        private EmailMessage CreatePasswordResetMessage(User user, string origin)
        {
            var message = "<h4>Reset Password Email</h4>\n";
            if (!string.IsNullOrEmpty(origin))
            {
                var resetUrl = $"{origin}/reset-password?token={user.ResetToken}";
                message += $@"<p>Please click the below link to reset your password, the link will be valid for 1 day:</p>
                            <p><a href=""{resetUrl}"">{resetUrl}</a></p>";
            }
            else
            {
                message += $@"<p>Please use the below token to reset your password with the <code>/accounts/reset-password</code> api route:</p>
                            <p><code>{user.ResetToken}</code></p>";
            }

            var targetName = $"{user.FirstName} {user.LastName}" ?? string.Empty;

            return new EmailMessage("ItechBy - Reset Password", message, new EmailAddress(user.Email, targetName));
        }
    }
}
