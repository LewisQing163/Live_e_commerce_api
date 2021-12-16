using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Live_e_commerce.Web
{
    [Dependency(ReplaceServices = true)]
    public class Live_e_commerceBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Live_e_commerce";
    }
}
