using Live_Commerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Live_Commerce.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(Live_CommerceEntityFrameworkCoreModule),
        typeof(Live_CommerceApplicationContractsModule)
        )]
    public class Live_CommerceDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
