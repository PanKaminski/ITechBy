using ITechBy.Domain.Common;
using Services.Abstractions.Data.Account;
using System.Text.Json.Serialization;

namespace Services.Abstractions.Data.Entities.Account
{
    public class CountryEntity : AuditableEntity
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }

        public ICollection<UserEntity> Users { get; set; } = new List<UserEntity>();
    }
}
