using Text_Abp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Text_Abp.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(Text_AbpEntityFrameworkCoreModule),
        typeof(Text_AbpApplicationContractsModule)
        )]
    public class Text_AbpDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
