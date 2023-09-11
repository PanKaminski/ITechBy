using Services.Abstractions.Data.Entities.Account;

namespace Services.Abstractions.Data.Repositories
{
    public interface IRefreshTokensRepository : IRepository<RefreshTokenEntity>
    {
        void DeleteByAccount(int accountId);
    }
}
