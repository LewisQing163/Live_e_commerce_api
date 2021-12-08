using Text_Abp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Text_Abp.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class Text_AbpController : AbpController
    {
        protected Text_AbpController()
        {
            LocalizationResource = typeof(Text_AbpResource);
        }
    }
}