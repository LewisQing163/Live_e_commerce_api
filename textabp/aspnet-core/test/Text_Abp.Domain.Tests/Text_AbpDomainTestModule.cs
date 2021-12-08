using Text_Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Text_Abp
{
    [DependsOn(
        typeof(Text_AbpEntityFrameworkCoreTestModule)
        )]
    public class Text_AbpDomainTestModule : AbpModule
    {

    }
}