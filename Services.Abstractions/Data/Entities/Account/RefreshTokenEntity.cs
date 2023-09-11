using ITechBy.Domain.Common;
using Services.Abstractions.Data.Account;

namespace Services.Abstractions.Data.Entities.Account
{
    public class RefreshTokenEntity : AuditableEntity
    {
        public string Source { get; set; }
        public DateTime ExpireTime { get; set; }

        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
