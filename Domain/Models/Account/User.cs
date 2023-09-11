using Domain.Common.Enums;

namespace Domain.Models.Account
{
    public class User : Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public GenderType Gender { get; set; }
    }
}
