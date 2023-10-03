using MediatR;

namespace Presentation.Authentication.Commands
{
    public record ValidateResetTokenCommand(string token) : IRequest;

    public class ValidateResetTokenHandler : IRequestHandler<ValidateResetTokenCommand>
    {
        private readonly AccountToolService accountToolService;

        public ValidateResetTokenHandler(AccountToolService accountToolService)
        {
            this.accountToolService = accountToolService ?? throw new ArgumentNullException(nameof(accountToolService));
        }

        public Task Handle(ValidateResetTokenCommand request, CancellationToken cancellationToken)
        {
            accountToolService.ValidateResetToken(request.token);

            return Task.CompletedTask;
        }
    }
}
