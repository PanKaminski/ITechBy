using Infrastructure.Implementations.DataMaster;
using Services.Abstractions.Data.Entities.Account;
using Services.Abstractions.Data.Entities.Learning;
using Services.Abstractions.Data.Repositories;

namespace Infrastructure.Implementations.Repositories
{
    public class LanguagesRepository : RepositoryBase<LanguageEntity>, ILanguagesRepository
    {
        public LanguagesRepository(ITechDbContext context) : base(context)
        {
        }

        public IEnumerable<LanguageEntity> GetByCodes(List<string> codes) 
            => DbContext.Languages.Where(l => codes.Contains(l.Code));
    }
}
