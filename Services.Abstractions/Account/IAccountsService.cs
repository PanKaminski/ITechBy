using Services.Abstractions.Common.OperationResult;
using Services.Abstractions.RequestModels.Account;

namespace Services.Abstractions.Account
{
    public interface IAccountsService
    {
        Task<ServerOperationResult> ForgotPasswordAsync(string email, string origin);
        AuthenticateResponseModel Login(string email, string password);
        Task<AuthenticateResponseModel> RefreshTokenAsync(string refreshTokenSource);
        Task<ServerOperationResult> RegisterAsync(RegisterRequestModel requestModel);
        ServerOperationResult ResetPassword(string token, string password);
        void ValidateResetToken(string token);
        ServerOperationResult VerifyEmail(string token);
    }
}
