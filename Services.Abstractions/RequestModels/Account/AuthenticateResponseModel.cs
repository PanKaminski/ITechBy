using Domain.Common.Enums;

namespace Services.Abstractions.RequestModels.Account
{
    public class AuthenticateResponseModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Picture { get; set; }

        public IEnumerable<RoleType> Roles { get; set; }

        public string JwtToken { get; set; }

    }
}
