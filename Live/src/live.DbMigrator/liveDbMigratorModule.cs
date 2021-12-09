using live.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace live.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(liveEntityFrameworkCoreModule),
        typeof(liveApplicationContractsModule)
        )]
    public class liveDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
