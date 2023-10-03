using MediatR;
using Presentation.Authentication.ViewModels;
using Services.Abstractions.Common.OperationResult;

namespace Presentation.Authentication.Commands
{
    public record ForgotPasswordCommand(ForgotPasswordModel model, string origin) : IRequest<ServerOperationResult>;

    public class ForgotPasswordHandler : IRequestHandler<ForgotPasswordCommand, ServerOperationResult>
    {
        private readonly AccountToolService accountToolService;

        public ForgotPasswordHandler(AccountToolService accountToolService)
        {
            this.accountToolService = accountToolService;
        }

        public async Task<ServerOperationResult> Handle(ForgotPasswordCommand request, CancellationToken cancellationToken)
        {
            return await accountToolService.ForgotPasswordAsync(request.model.Email, request.origin);
        }
    }
}
