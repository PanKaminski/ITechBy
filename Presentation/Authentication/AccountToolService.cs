using Presentation.Authentication.ViewModels;
using Services.Abstractions.Common;

namespace Presentation.Authentication
{
    public class AccountToolService
    {
        private readonly IEmailService emailService;

        public async Task RegisterAsync(RegisterModel registerModel, string origin)
        {
            ArgumentNullException.ThrowIfNull(nameof(registerModel));


        }
    }
}
