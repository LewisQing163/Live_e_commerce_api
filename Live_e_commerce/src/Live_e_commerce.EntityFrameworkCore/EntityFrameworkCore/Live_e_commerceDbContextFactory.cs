using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Live_e_commerce.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class Live_e_commerceDbContextFactory : IDesignTimeDbContextFactory<Live_e_commerceDbContext>
    {
        public Live_e_commerceDbContext CreateDbContext(string[] args)
        {
            Live_e_commerceEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<Live_e_commerceDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new Live_e_commerceDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Live_e_commerce.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
