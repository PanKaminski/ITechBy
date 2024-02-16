using MediatR;
using Services.Abstractions.Common;
using Services.Abstractions.Common.Models;

namespace Presentation.Common
{
    public record GetCountryItemsQuery() : IRequest<ICollection<SelectItem>>;

    public class GetCountryItemsHandler : IRequestHandler<GetCountryItemsQuery, ICollection<SelectItem>>
    {
        private readonly ISelectItemsService selectItemsService;
        public GetCountryItemsHandler(ISelectItemsService fakeDataStore) => selectItemsService = fakeDataStore;

        public async Task<ICollection<SelectItem>> Handle(GetCountryItemsQuery request,
            CancellationToken cancellationToken) => await selectItemsService.GetAllCountriesItems();

    }
}
