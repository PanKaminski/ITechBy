using MediatR;
using Presentation.Authentication.ViewModels;
using Services.Abstractions.Common.OperationResult;

namespace Presentation.Authentication.Commands
{
    public record ResetPasswordCommand(ResetPasswordModel model) : IRequest<ServerOperationResult>;

    public class ResetPasswordHandler : IRequestHandler<ResetPasswordCommand, ServerOperationResult>
    {
        private readonly AccountToolService accountToolService;

        public ResetPasswordHandler(AccountToolService accountToolService)
        {
            this.accountToolService = accountToolService;
        }

        public Task<ServerOperationResult> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(accountToolService.ResetPassword(request.model.Token, request.model.Password));
        }
    }
}
