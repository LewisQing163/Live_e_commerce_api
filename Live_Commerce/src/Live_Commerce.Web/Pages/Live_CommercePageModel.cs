using Live_Commerce.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Live_Commerce.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class Live_CommercePageModel : AbpPageModel
    {
        protected Live_CommercePageModel()
        {
            LocalizationResourceType = typeof(Live_CommerceResource);
        }
    }
}