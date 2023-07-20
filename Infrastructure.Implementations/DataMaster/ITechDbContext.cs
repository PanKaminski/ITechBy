using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Implementations.DataMaster
{
    public class ITechDbContext : DbContext
    {
        public ITechDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
