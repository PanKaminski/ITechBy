using Services.Abstractions.Common.Models;

namespace Services.Abstractions.Common
{
    public interface ISelectItemsService
    {
        Task<ICollection<SelectItem>> GetAllLanguageItems();
        Task<ICollection<SelectItem>> GetAllCountriesItems();
    }
}
