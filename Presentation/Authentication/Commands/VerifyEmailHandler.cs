using MediatR;
using Presentation.Authentication.ViewModels;
using Services.Abstractions.Common.OperationResult;

namespace Presentation.Authentication.Commands
{
    public record VerifyEmailCommand(VerificationModel model) : IRequest<ServerOperationResult>;

    public class VerifyEmailHandler : IRequestHandler<VerifyEmailCommand, ServerOperationResult>
    {
        private readonly AccountToolService accountToolService;

        public VerifyEmailHandler(AccountToolService accountToolService)
        {
            this.accountToolService = accountToolService ?? throw new ArgumentNullException(nameof(accountToolService));
        }

        public Task<ServerOperationResult> Handle(VerifyEmailCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(accountToolService.VerifyEmail(request.model.Token));
        }
    }
}
