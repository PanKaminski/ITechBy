using Domain.Common.Enums;
using MediatR;
using Presentation.Authentication.ViewModels;
using Services.Abstractions.Common.OperationResult;
using Services.Abstractions.RequestModels.Account;

namespace Presentation.Authentication.Commands
{
    public record RegisterCommand(RegisterModel model, string origin) : IRequest<ServerOperationResult>;

    public class RegisterHandler : IRequestHandler<RegisterCommand, ServerOperationResult>
    {
        private readonly AccountToolService accountToolService;

        public RegisterHandler(AccountToolService accounToolService)
        {
            this.accountToolService = accounToolService;
        }

        public async Task<ServerOperationResult> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var viewModel = new RegisterRequestModel(
                request.model.FirstName, 
                request.model.LastName,
                request.model.Email,
                request.model.Password,
                (GenderType)request.model.Gender,
                request.origin
            );

            return await accountToolService.RegisterAsync(viewModel);
        }
    }
}
