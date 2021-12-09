using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Live_Commerce.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class Live_CommerceDbContextFactory : IDesignTimeDbContextFactory<Live_CommerceDbContext>
    {
        public Live_CommerceDbContext CreateDbContext(string[] args)
        {
            Live_CommerceEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<Live_CommerceDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new Live_CommerceDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Live_Commerce.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
