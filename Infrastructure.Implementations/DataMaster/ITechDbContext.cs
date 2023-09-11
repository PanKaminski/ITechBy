using Microsoft.EntityFrameworkCore;
using Services.Abstractions.Data.Account;
using Services.Abstractions.Data.Entities.Account;

namespace Infrastructure.Implementations.DataMaster
{
    public class ITechDbContext : DbContext
    {
        public ITechDbContext(DbContextOptions options) : base(options) { }

        public DbSet<RefreshTokenEntity> RefreshTokens { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
