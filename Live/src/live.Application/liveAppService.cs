using System;
using System.Collections.Generic;
using System.Text;
using live.Localization;
using Volo.Abp.Application.Services;

namespace live
{
    /* Inherit your application services from this class.
     */
    public abstract class liveAppService : ApplicationService
    {
        protected liveAppService()
        {
            LocalizationResource = typeof(liveResource);
        }
    }
}
