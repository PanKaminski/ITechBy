using Domain.Common.Enums;
using ITechBy.Domain.Common;

namespace Services.Abstractions.Data.Entities.Learning
{
    public class LanguageLevelEntity : AuditableEntity
    {
        public LanguageLevel Level { get; set; }

        public ICollection<UserLanguageEntity> UserLanguages { get; set; } = new List<UserLanguageEntity>();
    }
}
