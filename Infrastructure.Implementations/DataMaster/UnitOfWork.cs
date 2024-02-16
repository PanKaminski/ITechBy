using Infrastructure.Implementations.Repositories;
using Microsoft.EntityFrameworkCore;
using Services.Abstractions.Data;
using Services.Abstractions.Data.Repositories;

namespace Infrastructure.Implementations.DataMaster
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ITechDbContext dbContext;

        public UnitOfWork(
            ITechDbContext dbContext, 
            IRefreshTokensRepository refreshTokensRepository, 
            IUsersRepository usersRepository, 
            IRolesRepository rolesRepository, 
            ILanguagesRepository languagesRepository, 
            ICountriesRepository countriesRepository,
            ILanguageLevelsRepository languageLevelsRepository
            )
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            RefreshTokensRepository = refreshTokensRepository ?? throw new ArgumentNullException(nameof(refreshTokensRepository));
            UsersRepository = usersRepository ?? throw new ArgumentNullException(nameof(usersRepository));
            RolesRepository = rolesRepository ?? throw new ArgumentNullException(nameof(rolesRepository));
            LanguagesRepository = languagesRepository ?? throw new ArgumentNullException(nameof(languagesRepository));
            CountriesRepository = countriesRepository ?? throw new ArgumentNullException(nameof(countriesRepository));
            LanguageLevelsRepository = languageLevelsRepository ?? throw new ArgumentNullException(nameof(languageLevelsRepository));
        }

        public IRefreshTokensRepository RefreshTokensRepository { get; }
        public IUsersRepository UsersRepository { get; }
        public IRolesRepository RolesRepository { get; }
        public ILanguagesRepository LanguagesRepository { get; }
        public ICountriesRepository CountriesRepository { get; }
        public ILanguageLevelsRepository LanguageLevelsRepository { get; }

        public void Commit() => dbContext.SaveChanges();

        public async Task CommitAsync() => await dbContext.SaveChangesAsync();

        public void RevertChanges()
        {
            foreach (var entry in dbContext.ChangeTracker.Entries()
                  .Where(e => e.State != EntityState.Unchanged))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }
    }
}
