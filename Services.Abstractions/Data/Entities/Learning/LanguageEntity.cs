using ITechBy.Domain.Common;

namespace Services.Abstractions.Data.Entities.Learning
{
    public class LanguageEntity : AuditableEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string NativeName { get; set; }

        public ICollection<UserLanguageEntity> UserLanguages { get; set; } = new List<UserLanguageEntity>();
    }
}