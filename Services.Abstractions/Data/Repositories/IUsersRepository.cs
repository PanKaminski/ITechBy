using Domain.Common;
using Services.Abstractions.Data.Account;
using Services.Abstractions.Data.Repositories.LoadOptions;
using System.Linq.Expressions;

namespace Services.Abstractions.Data.Repositories
{
    public interface IUsersRepository : IRepository<UserEntity>
    {
        bool Exists(string email);
        UserEntity Find(string email, bool trackEntity, List<AccountLoadOptions> loadOptions);
        Task<RandomPagedModel<UserEntity>> GetPaginatedByLanguagesAsync(int userId, ICollection<int> viewedPages, ICollection<int> languageCodes, int limit);
        UserEntity FirstOrDefault(Expression<Func<UserEntity, bool>> condition, bool trackEntity, List<AccountLoadOptions> loadOptions);
        Task<UserEntity> FirstOrDefaultAsync(Expression<Func<UserEntity, bool>> condition, bool trackEntity, List<AccountLoadOptions> loadOptions);
        bool HasAdminUser();
    }
}
