using System;
using System.Collections.Generic;
using System.Text;
using Text_Abp.Localization;
using Volo.Abp.Application.Services;

namespace Text_Abp
{
    /* Inherit your application services from this class.
     */
    public abstract class Text_AbpAppService : ApplicationService
    {
        protected Text_AbpAppService()
        {
            LocalizationResource = typeof(Text_AbpResource);
        }
    }
}
