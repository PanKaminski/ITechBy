using Domain.Common;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Presentation.Learning;
using Presentation.Learning.Queries;
using Services.Abstractions.Common.Models;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LanguagePartnersController : BaseAuthorizedController
    {
        private readonly IMediator mediator;

        public LanguagePartnersController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<RandomPagedModel<UserSearchCard>>> GetPossiblePartners(RandomPagedRequestModel pagedRequestModel) =>
            await mediator.Send(new GetLanguagePartnersQuery(CurrentUserId, pagedRequestModel.AttendedPages));
    }
}
