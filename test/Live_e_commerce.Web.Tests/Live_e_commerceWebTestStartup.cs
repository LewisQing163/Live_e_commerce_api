using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Live_e_commerce
{
    public class Live_e_commerceWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<Live_e_commerceWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}