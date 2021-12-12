using Live_e_commerce.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Live_e_commerce.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class Live_e_commercePageModel : AbpPageModel
    {
        protected Live_e_commercePageModel()
        {
            LocalizationResourceType = typeof(Live_e_commerceResource);
        }
    }
}