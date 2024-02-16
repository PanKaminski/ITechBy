using MediatR;
using Services.Abstractions.Common;
using Services.Abstractions.Common.Models;

namespace Presentation.Common
{
    public record GetLanguageItemsQuery() : IRequest<ICollection<SelectItem>>;

    public class GetLanguageItemsHandler: IRequestHandler<GetLanguageItemsQuery, ICollection<SelectItem>>
    {
        private readonly ISelectItemsService selectItemsService;
        public GetLanguageItemsHandler(ISelectItemsService fakeDataStore) => selectItemsService = fakeDataStore;

        public async Task<ICollection<SelectItem>> Handle(GetLanguageItemsQuery request,
            CancellationToken cancellationToken) => await selectItemsService.GetAllLanguageItems();
    }
}
