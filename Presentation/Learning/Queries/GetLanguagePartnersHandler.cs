using MediatR;
using Services.Abstractions.Common.Models;
using Domain.Common;
using Services.Abstractions.Learning;

namespace Presentation.Learning.Queries
{
    public record GetLanguagePartnersQuery(string userId, ICollection<int> viewedPages) : IRequest<RandomPagedModel<UserSearchCard>>;

    public class GetLanguagePartnersHandler : IRequestHandler<GetLanguagePartnersQuery, RandomPagedModel<UserSearchCard>>
    {
        private readonly ILanguagePartnersService languagePartnersService;
        public GetLanguagePartnersHandler(ILanguagePartnersService languagePartnersService) => 
            this.languagePartnersService = languagePartnersService;

        public async Task<RandomPagedModel<UserSearchCard>> Handle(GetLanguagePartnersQuery request,
            CancellationToken cancellationToken) => await languagePartnersService.FindPartners(request.userId, request.viewedPages);
    }

}
