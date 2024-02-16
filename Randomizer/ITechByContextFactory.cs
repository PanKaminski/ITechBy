using Infrastructure.Implementations.DataMaster;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    internal class ITechByContextFactory : IDesignTimeDbContextFactory<ITechDbContext>
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=ITechBy_dev;Trusted_Connection=True;MultipleActiveResultSets=true";

        public ITechDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ITechDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ITechDbContext(optionsBuilder.Options);
        }
    }
}
