using MediatR;
using Presentation.Authentication.ViewModels;
using Services.Abstractions.Account;
using Services.Abstractions.Common.OperationResult;

namespace Presentation.Authentication.Commands
{
    public record ResetPasswordCommand(ResetPasswordModel model) : IRequest<ServerOperationResult>;

    public class ResetPasswordHandler : IRequestHandler<ResetPasswordCommand, ServerOperationResult>
    {
        private readonly IAccountsService accountsService;

        public ResetPasswordHandler(IAccountsService accountsService)
        {
            this.accountsService = accountsService;
        }

        public Task<ServerOperationResult> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(accountsService.ResetPassword(request.model.Token, request.model.Password));
        }
    }
}
