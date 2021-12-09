using Volo.Abp.Modularity;

namespace live
{
    [DependsOn(
        typeof(liveApplicationModule),
        typeof(liveDomainTestModule)
        )]
    public class liveApplicationTestModule : AbpModule
    {

    }
}