using AutoMapper;
using LaundrySystem.UI.Data;
using LaundrySystem.UI.Entities;
using LaundrySystem.UI.Models;
using LaundrySystem.UI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaundrySystem.UI
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
            services.AddControllersWithViews();
            services.AddAutoMapper(typeof(Startup));

            var connectionString = Configuration["connectionStrings:DefaultConnection"];
            services.AddDbContext<LaundrydbContext>(o => o.UseSqlServer(connectionString));

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = ".AspNetCore.Identity.Application";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                options.SlidingExpiration = true;
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddScoped<ILaundryHttpClient, LaundryHttpClient>();
            services.AddHttpClient();

            services.AddScoped<IServiceRepo, ServiceRepo>();
            services.AddScoped<ICustomerRepo, CustomerRepo>();
            services.AddScoped<IProductRepo, ProductRepo>();
            services.AddScoped<IDataRepo, DataRepo>();
            //services.AddScoped<IProductRepo, ProductRepo>();
            //services.AddScoped<IProductStockRepo, ProductStockRepo>();
            //services.AddScoped<IUserRepo, UserRepo>();
            //services.AddScoped<ICategoryRepo, CategoryRepo>();
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
                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Dashboard}/{action=Index}/{id?}");
            });
        }
    }
}
