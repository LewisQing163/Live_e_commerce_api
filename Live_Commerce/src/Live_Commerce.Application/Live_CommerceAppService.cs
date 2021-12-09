using System;
using System.Collections.Generic;
using System.Text;
using Live_Commerce.Localization;
using Volo.Abp.Application.Services;

namespace Live_Commerce
{
    /* Inherit your application services from this class.
     */
    public abstract class Live_CommerceAppService : ApplicationService
    {
        protected Live_CommerceAppService()
        {
            LocalizationResource = typeof(Live_CommerceResource);
        }
    }
}
