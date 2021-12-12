using Volo.Abp.Modularity;

namespace Live_e_commerce
{
    [DependsOn(
        typeof(Live_e_commerceApplicationModule),
        typeof(Live_e_commerceDomainTestModule)
        )]
    public class Live_e_commerceApplicationTestModule : AbpModule
    {

    }
}