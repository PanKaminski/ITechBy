using Services.Abstractions.Common.Models;
using Services.Abstractions.Data.Entities.Account;
using Services.Abstractions.Data.Entities.Learning;

namespace Services.Abstractions.Extensions
{
    public static class SelectItemMappingExtensions
    {
        public static SelectItem ToSelectItem(this LanguageEntity language) => new SelectItem
        {
            Name = language.Name,
            Value = language.Code,
        };

        public static SelectItem ToSelectItem(this CountryEntity country) => new SelectItem 
        { 
            Name = country.Name,
            Value = country.Code,
        };
    }
}
