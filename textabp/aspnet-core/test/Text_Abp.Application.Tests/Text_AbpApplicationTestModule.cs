using Volo.Abp.Modularity;

namespace Text_Abp
{
    [DependsOn(
        typeof(Text_AbpApplicationModule),
        typeof(Text_AbpDomainTestModule)
        )]
    public class Text_AbpApplicationTestModule : AbpModule
    {

    }
}