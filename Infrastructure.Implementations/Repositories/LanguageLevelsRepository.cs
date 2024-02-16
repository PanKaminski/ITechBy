using Infrastructure.Implementations.DataMaster;
using Services.Abstractions.Data.Entities.Learning;
using Services.Abstractions.Data.Repositories;

namespace Infrastructure.Implementations.Repositories
{
    public class LanguageLevelsRepository : RepositoryBase<LanguageLevelEntity>, ILanguageLevelsRepository
    {
        public LanguageLevelsRepository(ITechDbContext context) : base(context)
        {
        }
    }
}
