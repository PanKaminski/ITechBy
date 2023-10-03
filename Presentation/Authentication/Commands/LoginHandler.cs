using MediatR;
using Presentation.Authentication.ViewModels;
using Services.Abstractions.RequestModels.Account;

namespace Presentation.Authentication.Commands
{
    public record LoginCommand(LoginModel model) : IRequest<AuthenticateResponseModel>;

    public class LoginHandler : IRequestHandler<LoginCommand, AuthenticateResponseModel>
    {
        private readonly AccountToolService accountToolService;

        public LoginHandler(AccountToolService accountToolService)
        {
            this.accountToolService = accountToolService;
        }

        public async Task<AuthenticateResponseModel> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(accountToolService.Login(request.model.Email, request.model.Password));
        }
    }
}
