using ECOTRAVEL_ASP.Handlers;
using ECOTRAVEL_COMMON.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLLEntities = ECOTRAVEL_BLL.Entities;
using BLLServices = ECOTRAVEL_BLL.Services;
using DALEntities = ECOTRAVEL_DAL.Entities;
using DALServices = ECOTRAVEL_DAL.Services;

namespace ECOTRAVEL_ASP
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

            services.AddHttpContextAccessor();

            services.AddScoped<SessionManager>();
            #region Cookies de consentement & de session

            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.Cookie.Name = "EcoTravel.Session";
                options.Cookie.HttpOnly = true;
                options.IdleTimeout = TimeSpan.FromMinutes(20);
                options.Cookie.IsEssential = true;
            });
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
                options.Secure = CookieSecurePolicy.Always;

            });
            #endregion
            #region Injection de dépendances (préparation)
            services.AddScoped<IClientRepository<BLLEntities.Client, int>, BLLServices.ClientService>();
            services.AddScoped<IClientRepository<DALEntities.Client, int>, DALServices.ClientService>();
            services.AddScoped<IProprietaireRepository<BLLEntities.Proprietaire, int>, BLLServices.ProprietaireService>();
            services.AddScoped<IProprietaireRepository<DALEntities.Proprietaire, int>, DALServices.ProprietaireService>();
            services.AddScoped<ITypeLogementRepository<BLLEntities.TypeLogement, int>, BLLServices.TypeLogementService>();
            services.AddScoped<ITypeLogementRepository<DALEntities.TypeLogement, int>, DALServices.TypeLogementService>();
            services.AddScoped<IAdresseRepository<BLLEntities.Adresse, int>, BLLServices.AdresseService>();
            services.AddScoped<IAdresseRepository<DALEntities.Adresse, int>, DALServices.AdresseService>();
            services.AddScoped<ILogementRepository<BLLEntities.Logement, int>, BLLServices.LogementService>();
            services.AddScoped<ILogementRepository<DALEntities.Logement, int>, DALServices.LogementService>();
            #endregion
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

            app.UseSession();
            app.UseCookiePolicy();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
