using Domain.Common.Enums;
using Domain.Models.Learning;

namespace Domain.Models.Account
{
    public class User : Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public GenderType Gender { get; set; }
        public ICollection<UserLanguage> Languages { get; set; } = new List<UserLanguage>();
    }
}
