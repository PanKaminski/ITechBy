using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Implementations.DataMaster
{
    public class DesignTimeITechContextFactory : IDesignTimeDbContextFactory<ITechDbContext>
    {
        public ITechDbContext CreateDbContext(string[] args)
        {
            const string connectionStringName = "ITECHBY";
            const string connectioStringPrefix = "SQLCONNSTR_";

            var configuration = new ConfigurationBuilder().AddEnvironmentVariables().Build();
            var connectionString = configuration.GetConnectionString(connectionStringName);

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception($"{connectioStringPrefix}{connectionStringName} environment variable is not set.");
            }

            Console.WriteLine($"Using {connectioStringPrefix}{connectionStringName} environment variable as a connection string.");

            var builderOptions = new DbContextOptionsBuilder<ITechDbContext>().UseSqlServer(connectionString).Options;
            return new ITechDbContext(builderOptions);
        }
    }
}
