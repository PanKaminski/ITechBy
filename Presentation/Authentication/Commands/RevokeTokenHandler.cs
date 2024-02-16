using MediatR;
using Services.Abstractions.Common.OperationResult;

namespace Presentation.Authentication.Commands
{
    public record RevokeTokenCommand(string rtToken) : IRequest<ServerOperationResult>;

    public class RevokeTokenHandler : IRequestHandler<RevokeTokenCommand, ServerOperationResult>
    {
        private readonly AccountToolService accountToolService;

        public RevokeTokenHandler(AccountToolService accountToolService)
        {
            this.accountToolService = accountToolService;
        }

        public async Task<ServerOperationResult> Handle(RevokeTokenCommand request, CancellationToken cancellationToken)
        {
            return await accountToolService.RevokeTokenAsync(request.rtToken);
        }
    }
}
