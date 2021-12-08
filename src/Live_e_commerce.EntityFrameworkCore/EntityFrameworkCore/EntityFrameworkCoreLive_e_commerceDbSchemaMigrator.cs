using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Live_e_commerce.Data;
using Volo.Abp.DependencyInjection;

namespace Live_e_commerce.EntityFrameworkCore
{
    public class EntityFrameworkCoreLive_e_commerceDbSchemaMigrator
        : ILive_e_commerceDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreLive_e_commerceDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the Live_e_commerceDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<Live_e_commerceDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
