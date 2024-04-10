using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.Servicios;
using Frontend_Sistema_Votaciones.WebAPI;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones
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
            services.AddSession();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<API>();
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.AddControllersWithViews();
            services.AddScoped<UsuariosServicios>();
            services.AddScoped<PantallasServicios>();
            services.AddScoped<RolesServicios>();
            services.AddScoped<DepartamentoServicios>();
            services.AddScoped<MunicipioServicios>();
            services.AddScoped<CargoServicios>();
            services.AddScoped<EstadosCivilesServicios>();
            services.AddScoped<EmpleadoServicios>();
            services.AddScoped<SedesServicios>();
            services.AddScoped<MesasServicios>();
            services.AddScoped<VotanteServicios>();
            services.AddScoped<PartidoServicios>();
            services.AddScoped<AlcaldeServicios>();
            services.AddScoped<PresidenteServicios>();
            services.AddScoped<VotosPorMesaServicios>();
            services.AddScoped<BlobStorage>();
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
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
