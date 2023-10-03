using MediatR;
using Services.Abstractions.RequestModels.Account;

namespace Presentation.Authentication.Commands
{
    public record RefreshTokenCommand(string refreshToken) : IRequest<AuthenticateResponseModel>;

    public class RefreshTokenHandler : IRequestHandler<RefreshTokenCommand, AuthenticateResponseModel>
    {
        private readonly AccountToolService accountToolService;

        public RefreshTokenHandler(AccountToolService accountToolService)
        {
            this.accountToolService = accountToolService;
        }

        public async Task<AuthenticateResponseModel> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            return await accountToolService.RefreshTokenAsync(request.refreshToken);
        }
    }
}