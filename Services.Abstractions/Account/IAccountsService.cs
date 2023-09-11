using Services.Abstractions.Common.OperationResult;
using Services.Abstractions.RequestModels.Account;

namespace Services.Abstractions.Account
{
    public interface IAccountsService
    {
        Task<ServerOperationResult> RegisterAsync(RegisterRequestModel requestModel);

        
    }
}
