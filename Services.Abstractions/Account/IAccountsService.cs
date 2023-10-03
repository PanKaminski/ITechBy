using Domain.Models.Account;
using Services.Abstractions.RequestModels.Account;

namespace Services.Abstractions.Account
{
    public interface IAccountsService
    {
        Task<User> ForgotPasswordAsync(string email, string origin);
        AuthenticateResponseModel Login(string email, string password);
        Task<AuthenticateResponseModel> RefreshTokenAsync(string refreshTokenSource);
        Task<User> RegisterAsync(RegisterRequestModel requestModel);
        void ResetPassword(string token, string password);
        void ValidateResetToken(string token);
        bool VerifyEmail(string token);
    }
}
