using MediatR;
using Presentation.Authentication.ViewModels;
using Services.Abstractions.Account;
using Services.Abstractions.Common.OperationResult;

namespace Presentation.Authentication.Commands
{
    public record VerifyEmailCommand(VerificationModel model) : IRequest<ServerOperationResult>;

    public class VerifyEmailHandler : IRequestHandler<VerifyEmailCommand, ServerOperationResult>
    {
        private readonly IAccountsService accountsService;

        public VerifyEmailHandler(IAccountsService accountsService)
        {
            this.accountsService = accountsService ?? throw new ArgumentNullException(nameof(accountsService));
        }

        public Task<ServerOperationResult> Handle(VerifyEmailCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(accountsService.VerifyEmail(request.model.Token));
        }
    }
}
