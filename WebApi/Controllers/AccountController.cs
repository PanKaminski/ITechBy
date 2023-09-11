using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Authentication.ViewModels;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public AccountController(IMediator mediator)
        {
            this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public readonly IMediator mediator;

        [HttpPost]
        public async Task<IActionResult> RegisterAsync(RegisterModel model)
        {
            return Ok(new { message = "Registration successful. Check your email for account verification" }); ;
        }
    }
}
