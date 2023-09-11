using Infrastructure.Implementations.DataMaster;
using Services.Abstractions.Data.Entities.Account;
using Services.Abstractions.Data.Repositories;

namespace Infrastructure.Implementations.Repositories
{
    public class RefreshTokensRepository : RepositoryBase<RefreshTokenEntity>, IRefreshTokensRepository
    {
        public RefreshTokensRepository(ITechDbContext context) : base(context)
        {
        }

        public void DeleteByAccount(int accountId)
        {
            var rt = DbContext.RefreshTokens.FirstOrDefault(rt => rt.UserId == accountId);
            if (rt is not null) DbContext.RefreshTokens.Remove(rt);
        }
    }
}
