using Domain.Common.Enums;
using Domain.Models.Account;

namespace Domain.Models.Learning
{
    public class UserLanguage
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Language Language { get; set; }
        public LanguageLevel Level { get; set; }
        public bool IsInLearning { get; set; }
    }
}
