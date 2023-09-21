using Domain.Common.Enums;
using Infrastructure.Implementations.DataMaster;
using Microsoft.EntityFrameworkCore;
using Services.Abstractions.Data.Account;
using Services.Abstractions.Data.Repositories;
using Services.Abstractions.Data.Repositories.LoadOptions;

namespace Infrastructure.Implementations.Repositories
{
    public class UsersRepository : RepositoryBase<UserEntity>, IUsersRepository
    {
        public UsersRepository(ITechDbContext context) : base(context)
        {
        }

        public bool Exists(string email) => Get(acc => acc.Email == email, false).Any();

        public UserEntity Find(string email, bool trackEntity, List<AccountLoadOptions> loadOptions)
        {
            IQueryable<UserEntity> usersModel = InitModel(loadOptions);

            if (!trackEntity) usersModel = usersModel.AsNoTracking();

            return usersModel.First(u => u.Email == email);
        }

        public async Task<UserEntity> FirstOrDefaultAsync(Predicate<UserEntity> condition, bool trackEntity, List<AccountLoadOptions> loadOptions)
        {
            IQueryable<UserEntity> usersModel = InitModel(loadOptions);

            if (!trackEntity) usersModel = usersModel.AsNoTracking();

            return await usersModel.FirstOrDefaultAsync(item => condition(item));
        }

        public bool HasAdminUser() => DbContext.Users.Include(u => u.Roles)
            .Any(u => u.Roles.Any(r => r.Type == RoleType.Admin));

        private IQueryable<UserEntity> InitModel(List<AccountLoadOptions> loadOptions)
        {
            IQueryable<UserEntity> model = DbContext.Users;

            if (loadOptions is null || loadOptions.Count == 0) return model;

            if (loadOptions.Contains(AccountLoadOptions.WithRoles))
            {
                model = model.Include(u => u.Roles);
            }

            if (loadOptions.Contains(AccountLoadOptions.WithRefreshTokens))
            {
                model = model.Include(u => u.RefreshToken);
            }

            return model;
        }
    }
}
