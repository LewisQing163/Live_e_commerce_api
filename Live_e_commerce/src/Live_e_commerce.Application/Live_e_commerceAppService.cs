using System;
using System.Collections.Generic;
using System.Text;
using Live_e_commerce.Localization;
using Volo.Abp.Application.Services;

namespace Live_e_commerce
{
    /* Inherit your application services from this class.
     */
    public abstract class Live_e_commerceAppService : ApplicationService
    {
        protected Live_e_commerceAppService()
        {
            LocalizationResource = typeof(Live_e_commerceResource);
        }
    }
}
