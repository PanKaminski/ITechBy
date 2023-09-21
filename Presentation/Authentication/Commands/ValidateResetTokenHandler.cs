using MediatR;
using Services.Abstractions.Account;

namespace Presentation.Authentication.Commands
{
    public record ValidateResetTokenCommand(string token) : IRequest;

    public class ValidateResetTokenHandler : IRequestHandler<ValidateResetTokenCommand>
    {
        private readonly IAccountsService accountsService;

        public ValidateResetTokenHandler(IAccountsService accountsService)
        {
            this.accountsService = accountsService ?? throw new ArgumentNullException(nameof(accountsService));
        }

        public Task Handle(ValidateResetTokenCommand request, CancellationToken cancellationToken)
        {
            accountsService.ValidateResetToken(request.token);

            return Task.CompletedTask;
        }
    }
}
