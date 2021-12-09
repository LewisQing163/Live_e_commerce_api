using Live_Commerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Live_Commerce.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class Live_CommerceController : AbpController
    {
        protected Live_CommerceController()
        {
            LocalizationResource = typeof(Live_CommerceResource);
        }
    }
}