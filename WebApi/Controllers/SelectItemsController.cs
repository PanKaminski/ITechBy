using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Common;
using Services.Abstractions.Common.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SelectItemsController : ControllerBase
    {
        private readonly IMediator mediator;

        public SelectItemsController(IMediator mediator)
        {
            this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet]
        public async Task<ICollection<SelectItem>> GetLanguageItems()
        {
            return await mediator.Send(new GetLanguageItemsQuery());
        }

        [HttpGet]
        public async Task<ICollection<SelectItem>> GetCountryItems()
        {
            return await mediator.Send(new GetCountryItemsQuery());
        }

    }
}
