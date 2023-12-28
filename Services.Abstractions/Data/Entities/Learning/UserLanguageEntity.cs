using ITechBy.Domain.Common;
using Services.Abstractions.Data.Account;

namespace Services.Abstractions.Data.Entities.Learning
{
    public class UserLanguageEntity : AuditableEntity
    {
        public int UserId { get; set; }
        public UserEntity User { get; set; }

        public int LanguageId { get; set; }
        public LanguageEntity Language { get; set; }

        public int LevelId { get; set; }
        public LanguageLevelEntity Level { get; set; }

        public bool IsInLearning { get; set; }
    }
}
