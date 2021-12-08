using Live_e_commerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Live_e_commerce
{
    [DependsOn(
        typeof(Live_e_commerceEntityFrameworkCoreTestModule)
        )]
    public class Live_e_commerceDomainTestModule : AbpModule
    {

    }
}