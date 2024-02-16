using Domain.Common;
using Services.Abstractions.Common.Models;

namespace Services.Abstractions.Learning
{
    public interface ILanguagePartnersService
    {
        Task<RandomPagedModel<UserSearchCard>> FindPartners(string userIdString, ICollection<int> viewedPages);
    }
}
