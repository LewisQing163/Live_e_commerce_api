using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Text_Abp.Data;
using Volo.Abp.DependencyInjection;

namespace Text_Abp.EntityFrameworkCore
{
    public class EntityFrameworkCoreText_AbpDbSchemaMigrator
        : IText_AbpDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreText_AbpDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the Text_AbpDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<Text_AbpDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
