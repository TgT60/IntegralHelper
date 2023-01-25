using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using HelperAPI.Service;

namespace HelperAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerDocument();
            Configuration.Bind("Project",new Config());
            services.AddControllersWithViews()   // подключаем контролеры для паттерна MVC
                    .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider(); // установка совместимости версий
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUi3();

            }

            app.UseRouting();

            app.UseStaticFiles();       // добовляем поддержку файлов типа (js,css,img и т.д) 

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");
               
            });
        }
    }
}
