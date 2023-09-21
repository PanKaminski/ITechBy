using MediatR;
using Services.Abstractions.Account;
using Services.Abstractions.RequestModels.Account;

namespace Presentation.Authentication.Commands
{
    public record RefreshTokenCommand(string refreshToken) : IRequest<AuthenticateResponseModel>;

    public class RefreshTokenHandler : IRequestHandler<RefreshTokenCommand, AuthenticateResponseModel>
    {
        private readonly IAccountsService accountsService;

        public RefreshTokenHandler(IAccountsService accountsService)
        {
            this.accountsService = accountsService;
        }

        public async Task<AuthenticateResponseModel> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            return await accountsService.RefreshTokenAsync(request.refreshToken);
        }
    }
}