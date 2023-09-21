using Services.Abstractions.Data.Account;
using Services.Abstractions.Data.Repositories.LoadOptions;

namespace Services.Abstractions.Data.Repositories
{
    public interface IUsersRepository : IRepository<UserEntity>
    {
        bool Exists(string email);
        UserEntity Find(string email, bool trackEntity, List<AccountLoadOptions> loadOptions);
        Task<UserEntity> FirstOrDefaultAsync(Predicate<UserEntity> condition, bool trackEntity, List<AccountLoadOptions> loadOptions);
        bool HasAdminUser();
    }
}
