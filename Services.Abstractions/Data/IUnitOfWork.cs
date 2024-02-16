using Services.Abstractions.Data.Repositories;

namespace Services.Abstractions.Data
{
    public interface IUnitOfWork
    {
        IRefreshTokensRepository RefreshTokensRepository { get; }
        IUsersRepository UsersRepository { get; }
        IRolesRepository RolesRepository { get; }
        ILanguagesRepository LanguagesRepository { get; }
        ILanguageLevelsRepository LanguageLevelsRepository { get; }
        ICountriesRepository CountriesRepository { get; }

        void Commit();
        Task CommitAsync();
        void RevertChanges();
    }
}
