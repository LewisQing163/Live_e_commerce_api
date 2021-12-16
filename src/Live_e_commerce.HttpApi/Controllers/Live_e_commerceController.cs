using Live_e_commerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Live_e_commerce.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class Live_e_commerceController : AbpController
    {
        protected Live_e_commerceController()
        {
            LocalizationResource = typeof(Live_e_commerceResource);
        }
    }
}