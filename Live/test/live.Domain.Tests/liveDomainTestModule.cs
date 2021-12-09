using live.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace live
{
    [DependsOn(
        typeof(liveEntityFrameworkCoreTestModule)
        )]
    public class liveDomainTestModule : AbpModule
    {

    }
}