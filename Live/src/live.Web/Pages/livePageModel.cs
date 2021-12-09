using live.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace live.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class livePageModel : AbpPageModel
    {
        protected livePageModel()
        {
            LocalizationResourceType = typeof(liveResource);
        }
    }
}