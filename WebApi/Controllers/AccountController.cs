using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Presentation.Authentication.Commands;
using Presentation.Authentication.ViewModels;
using Services.Abstractions.Common.OperationResult;
using Services.Abstractions.RequestModels.Account;
using Services.Implementations.Account.Utils;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly JwtSettings jwtSettings;

        public AccountController(IMediator mediator, IOptions<JwtSettings> jwtSettings)
        {
            this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            this.jwtSettings = jwtSettings?.Value ?? throw new ArgumentNullException(nameof(jwtSettings));
        }

        private string Origin => Request?.Headers["origin"];

        [HttpPost]
        public async Task<ActionResult<ServerOperationResult>> RegisterAsync(RegisterModel model)
        {
            return await mediator.Send(new RegisterCommand(model, Origin));
        }

        [HttpPost]
        public async Task<ActionResult<AuthenticateResponseModel>> LoginAsync(LoginModel model)
        {
            var authResult = await mediator.Send(new LoginCommand(model));

            SetTokenCookie(authResult.RefreshToken);

            return Ok(authResult);
        }

        [HttpPost]
        public async Task<ActionResult<AuthenticateResponseModel>> RefreshTokenAsync(RevokeTokenModel model)
        {
            var token = model.RefreshToken ?? Request.Cookies["refreshToken"];
            var authResult = await mediator.Send(new RefreshTokenCommand(token));

            SetTokenCookie(authResult.RefreshToken);

            return Ok(authResult);
        }

        [HttpPost]
        public async Task<ActionResult<ServerOperationResult>> RevokeTokenAsync(RevokeTokenModel model)
        {
            var token = model.RefreshToken ?? Request.Cookies["refreshToken"];

            if (string.IsNullOrEmpty(token))
            {
                return BadRequest(new { message = "Token is required" });
            }

            return await mediator.Send(new RevokeTokenCommand(token));
        }

        [HttpPost]
        public async Task<ActionResult<ServerOperationResult>> VerifyEmailAsync(VerificationModel verificationModel)
        {
            return await mediator.Send(new VerifyEmailCommand(verificationModel));
        }

        [HttpPost]
        public async Task<ActionResult<ServerOperationResult>> ForgotPasswordAsync(ForgotPasswordModel model)
        {
            return await mediator.Send(new ForgotPasswordCommand(model, Origin));
        }

        [HttpPost]
        public async Task<IActionResult> ValidateResetTokenAsync(string token)
        {
            await mediator.Send(new ValidateResetTokenCommand(token));

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<ServerOperationResult>> ResetPasswordAsync(ResetPasswordModel model)
        {
            return await mediator.Send(new ResetPasswordCommand(model));
        }

        private void SetTokenCookie(string token)
        {
            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.UtcNow.AddDays(jwtSettings.RefreshTokenExpireTimeDays),
                HttpOnly = true,
                //Secure = false,
                SameSite = SameSiteMode.Strict
            };

            Response.Cookies.Append("refreshToken", token, cookieOptions);
        }
    }
}
