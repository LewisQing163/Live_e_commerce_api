using Live_Commerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Live_Commerce
{
    [DependsOn(
        typeof(Live_CommerceEntityFrameworkCoreTestModule)
        )]
    public class Live_CommerceDomainTestModule : AbpModule
    {

    }
}