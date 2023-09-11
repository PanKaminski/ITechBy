using Infrastructure.Implementations.DataMaster;
using Services.Abstractions.Data.Account;
using Services.Abstractions.Data.Repositories;

namespace Infrastructure.Implementations.Repositories
{
    public class RolesRepository : RepositoryBase<RoleEntity>, IRolesRepository
    {
        public RolesRepository(ITechDbContext context) : base(context)
        {
        }
    }
}
