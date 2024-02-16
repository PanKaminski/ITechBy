using Domain.Common;
using Domain.Common.Enums;
using Infrastructure.Implementations.DataMaster;
using Infrastructure.Implementations.Extensions;
using Microsoft.EntityFrameworkCore;
using Services.Abstractions.Data.Account;
using Services.Abstractions.Data.Repositories;
using Services.Abstractions.Data.Repositories.LoadOptions;
using System.Linq.Expressions;

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

        public async Task<UserEntity> FirstOrDefaultAsync(Expression<Func<UserEntity, bool>> condition, bool trackEntity, List<AccountLoadOptions> loadOptions)
        {
            IQueryable<UserEntity> usersModel = InitModel(loadOptions);

            if (!trackEntity) usersModel = usersModel.AsNoTracking();

            return await usersModel.FirstOrDefaultAsync(condition);
        }

        public UserEntity FirstOrDefault(Expression<Func<UserEntity, bool>> condition, bool trackEntity, List<AccountLoadOptions> loadOptions)
        {
            IQueryable<UserEntity> usersModel = InitModel(loadOptions);

            if (!trackEntity) usersModel = usersModel.AsNoTracking();

            return usersModel.FirstOrDefault(condition);
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

            if (loadOptions.Contains(AccountLoadOptions.WithLanguages))
            {
                model = model.Include(u => u.Languages).ThenInclude(ul => ul.Language);
            }

            if (loadOptions.Contains(AccountLoadOptions.WithCountries))
            {
                model = model.Include(u => u.Country);
            }

            return model;
        }

        public Task<RandomPagedModel<UserEntity>> GetPaginatedByLanguagesAsync(int userId, ICollection<int> viewedPages, ICollection<int> languageCodes, int limit)
        {
            var model = InitModel(new List<AccountLoadOptions> { AccountLoadOptions.WithLanguages, AccountLoadOptions.WithCountries });

            //model = model.Where(u => u.Id != userId && u.Languages.Any(l => languageCodes.Contains(l.LanguageId)));
            model.AsNoTracking();

            return model.RandomPaginateAsync(viewedPages, limit);
        }
    }
}
