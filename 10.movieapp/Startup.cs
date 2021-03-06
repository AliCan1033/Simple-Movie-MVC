using System;
using System.Collections.Generic;
using System.IO;//Path için
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;//StaticFileOptionsiçin
using Microsoft.Extensions.Hosting;

namespace movieapp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
             //services.AddMvc(option => option.EnableEndpointRouting = false);
             services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();//wwwroot=> /css/style.cs or /img/1.jpg

            app.UseStaticFiles(new StaticFileOptions{//node_modules=> /modules/bootstrap/dist/bootstrap.min.css or min.js
                FileProvider=new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
                RequestPath="/modules"
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //app.UseMvcWithDefaultRoute();
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern:"{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
