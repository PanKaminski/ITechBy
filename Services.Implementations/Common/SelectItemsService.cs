using Services.Abstractions.Common;
using Services.Abstractions.Common.Models;
using Services.Abstractions.Data.Repositories;
using Services.Abstractions.Extensions;

namespace Services.Implementations.Common
{
    public class SelectItemsService : ISelectItemsService
    {
        private readonly ILanguagesRepository languagesRepository;
        private readonly ICountriesRepository countriesRepository;

        public SelectItemsService(ILanguagesRepository languagesRepository, ICountriesRepository countriesRepository)
        {
            this.languagesRepository = languagesRepository ?? throw new ArgumentNullException(nameof(languagesRepository));
            this.countriesRepository = countriesRepository ?? throw new ArgumentNullException(nameof(countriesRepository));
        }

        public async Task<ICollection<SelectItem>> GetAllCountriesItems() =>
            (await countriesRepository.GetAllInChunkAsync(false)).Select(c => c.ToSelectItem()).ToList();

        public async Task<ICollection<SelectItem>> GetAllLanguageItems() =>
            (await languagesRepository.GetAllInChunkAsync(false)).Select(l => l.ToSelectItem()).ToList();
    }
}
