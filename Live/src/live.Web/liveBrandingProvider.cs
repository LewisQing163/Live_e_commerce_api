using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace live.Web
{
    [Dependency(ReplaceServices = true)]
    public class liveBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "live";
    }
}
