using live.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace live.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class liveController : AbpController
    {
        protected liveController()
        {
            LocalizationResource = typeof(liveResource);
        }
    }
}