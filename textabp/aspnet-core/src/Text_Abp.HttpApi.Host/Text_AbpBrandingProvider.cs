using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Text_Abp
{
    [Dependency(ReplaceServices = true)]
    public class Text_AbpBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Text_Abp";
    }
}
