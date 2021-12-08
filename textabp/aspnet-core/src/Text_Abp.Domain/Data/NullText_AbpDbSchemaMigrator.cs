using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Text_Abp.Data
{
    /* This is used if database provider does't define
     * IText_AbpDbSchemaMigrator implementation.
     */
    public class NullText_AbpDbSchemaMigrator : IText_AbpDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}