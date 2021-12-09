using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Live_Commerce.Web
{
    [Dependency(ReplaceServices = true)]
    public class Live_CommerceBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Live_Commerce";
    }
}
