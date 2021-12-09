using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Live_Commerce.Data
{
    /* This is used if database provider does't define
     * ILive_CommerceDbSchemaMigrator implementation.
     */
    public class NullLive_CommerceDbSchemaMigrator : ILive_CommerceDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}