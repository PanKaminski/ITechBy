using Services.Abstractions.Data.Entities.Learning;

namespace Services.Abstractions.Data.Repositories
{
    public interface ILanguagesRepository : IRepository<LanguageEntity>
    {
        IEnumerable<LanguageEntity> GetByCodes(List<string> codes);
    }
}
