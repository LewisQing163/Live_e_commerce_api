using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Live_e_commerce.Data
{
    /* This is used if database provider does't define
     * ILive_e_commerceDbSchemaMigrator implementation.
     */
    public class NullLive_e_commerceDbSchemaMigrator : ILive_e_commerceDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}