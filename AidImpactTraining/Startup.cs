using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AidImpactTraining.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic;

namespace AidImpactTraining
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        // this constructor populate the configuration automatically when it starts
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // We register the FormattingService class
            services.AddTransient<FormattingService>();

            // This portion of code is retrieve the configuration file called "appsettings.json" and use it to get the configuration data
            services.AddTransient<FeatureToggles>(feature => new FeatureToggles
            {
                DeveloperExceptions = configuration.GetValue<bool>("FeatureToggles:DeveloperExceptions")
            });

            // Set up entity framework 
            services.AddDbContext<BlogDataContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("BlogDataContext");
                options.UseSqlServer(connectionString);
            });

            // I disabled the endpointRouting principally because I learned with the MVC methods for the routing. So that's why
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app, 
            IWebHostEnvironment env,
            FeatureToggles features)
        {
            app.UseExceptionHandler("/error");

            if (features.DeveloperExceptions)
            {
                app.UseDeveloperExceptionPage();
            }

            // Test the exception with a specific route (if it contains "invalid" for example)
            app.Use(async (context, next) =>
            {
                if (context.Request.Path.Value.Contains("invalid"))
                {
                    throw new Exception("Error, this path is invalid. Please try again.");
                }
                await next();
            });

            // Set up the basic routing for MVC
            app.UseMvc(routes =>
            {
                routes.MapRoute("Default",
                    "{controller=Home}/{action=Index}/{id?}");
            });

            // Allows me to show my server files in the "wwwroot" folder
            app.UseFileServer();
        }
    }
}
