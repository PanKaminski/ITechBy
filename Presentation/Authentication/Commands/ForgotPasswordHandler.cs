using MediatR;
using Presentation.Authentication.ViewModels;
using Services.Abstractions.Account;
using Services.Abstractions.Common.OperationResult;

namespace Presentation.Authentication.Commands
{
    public record ForgotPasswordCommand(ForgotPasswordModel model, string origin) : IRequest<ServerOperationResult>;

    public class ForgotPasswordHandler : IRequestHandler<ForgotPasswordCommand, ServerOperationResult>
    {
        private readonly IAccountsService accountsService;

        public ForgotPasswordHandler(IAccountsService accountsService)
        {
            this.accountsService = accountsService;
        }

        public async Task<ServerOperationResult> Handle(ForgotPasswordCommand request, CancellationToken cancellationToken)
        {
            return await accountsService.ForgotPasswordAsync(request.model.Email, request.origin);
        }
    }
}
