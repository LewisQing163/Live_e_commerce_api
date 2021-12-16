using Live_e_commerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Live_e_commerce.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(Live_e_commerceEntityFrameworkCoreModule),
        typeof(Live_e_commerceApplicationContractsModule)
        )]
    public class Live_e_commerceDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
