using Services.Abstractions.Data.Account;

namespace Services.Abstractions.Data.Entities.Account
{
    public class UserRoleEntity
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
