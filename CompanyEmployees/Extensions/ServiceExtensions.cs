using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyEmployees.Extensions
{
    public static class ServiceExtensions
    {
        /// <summary>
        /// CORS (Cross – Origin Resource Sharing) is a mechanism to give or restrict access rights to applications from different domains.
        /// AllowAnyOrigin() --> we can use the WithOrigins(“https://example.com”) 
        /// AllowAnyMethod() --> we can use WithMethods(“POST”,”GET”) 
        /// AllowAnyHeader() --> we can use WithHeaders(“accept”,”content-type”) 
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureCors(this IServiceCollection services) => 
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

        /// <summary>
        /// If we want to host our application on IIS, we need to configure an IIS integration
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            { });

    }
}
