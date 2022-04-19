using DataAccessLayer;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRehber
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PeopleDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("MssqlConnection")));
            services.AddControllersWithViews();
           services.AddScoped<IRepositoryPerson, PersonRepository>();

            // services.AddTransient<Test>();//whenever u need this service create a new instance of this service
            // services.AddSingleton<Test>();//onece u need this service create it , if u need this service again use the one that u have create already
            //    services.AddScoped<IRepositoryPerson, PersonRepositoryJson>();
            services.AddTransient<Test>();
            services.AddTransient<Test1>();
            services.AddScoped<Deneme,Deneme>();//Create only one instance for each Request scope
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    //  pattern: "{controller=Home}/{action=Index}/{id?}");
                    pattern: "{controller=Home}/{action=CreatePerson}/{id?}");
            });
        }
    }
}
