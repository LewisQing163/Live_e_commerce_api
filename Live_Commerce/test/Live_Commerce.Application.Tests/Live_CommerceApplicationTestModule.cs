using Volo.Abp.Modularity;

namespace Live_Commerce
{
    [DependsOn(
        typeof(Live_CommerceApplicationModule),
        typeof(Live_CommerceDomainTestModule)
        )]
    public class Live_CommerceApplicationTestModule : AbpModule
    {

    }
}