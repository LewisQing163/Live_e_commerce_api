using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace live.Data
{
    /* This is used if database provider does't define
     * IliveDbSchemaMigrator implementation.
     */
    public class NullliveDbSchemaMigrator : IliveDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}