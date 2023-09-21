using MediatR;
using Presentation.Authentication.ViewModels;
using Services.Abstractions.Account;
using Services.Abstractions.RequestModels.Account;

namespace Presentation.Authentication.Commands
{
    public record LoginCommand(LoginModel model) : IRequest<AuthenticateResponseModel>;

    public class LoginHandler : IRequestHandler<LoginCommand, AuthenticateResponseModel>
    {
        private readonly IAccountsService accountsService;

        public LoginHandler(IAccountsService accountsService)
        {
            this.accountsService = accountsService;
        }

        public async Task<AuthenticateResponseModel> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(accountsService.Login(request.model.Email, request.model.Password));
        }
    }
}
