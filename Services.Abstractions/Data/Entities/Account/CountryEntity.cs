using ITechBy.Domain.Common;
using Services.Abstractions.Data.Account;

namespace Services.Abstractions.Data.Entities.Account
{
    public class CountryEntity : AuditableEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<UserEntity> Users { get; set; } = new List<UserEntity>();
    }
}
