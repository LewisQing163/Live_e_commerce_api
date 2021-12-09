using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Live_Commerce.Data;
using Volo.Abp.DependencyInjection;

namespace Live_Commerce.EntityFrameworkCore
{
    public class EntityFrameworkCoreLive_CommerceDbSchemaMigrator
        : ILive_CommerceDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreLive_CommerceDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the Live_CommerceDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<Live_CommerceDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
