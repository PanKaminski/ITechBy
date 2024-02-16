using Infrastructure.Implementations.DataMaster;
using Services.Abstractions.Data.Entities.Account;
using Services.Abstractions.Data.Repositories;

namespace Infrastructure.Implementations.Repositories
{
    public class CountriesRepository : RepositoryBase<CountryEntity>, ICountriesRepository
    {
        public CountriesRepository(ITechDbContext context) : base(context)
        {
        }
    }
}
