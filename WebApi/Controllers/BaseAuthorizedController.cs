using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseAuthorizedController : ControllerBase
    {
        public string CurrentUserId => User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;
    }
}
