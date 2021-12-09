using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Live_Commerce
{
    public class Live_CommerceWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<Live_CommerceWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}