using Services.Abstractions.Data.Account;

namespace Services.Abstractions.Data.Entities.Account
{
    public class UserRoleEntity
    {
        public int UsersId { get; set; }
        public UserEntity User { get; set; } = null!;

        public int RolesId { get; set; }
        public RoleEntity Role { get; set; } = null!;
    }
}
