using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Sistema_Votaciones.BusinessLogic.Services;
using Sistema_Votaciones.DataAcces;
using Sistema_Votaciones.DataAcess;
using Sistema_Votaciones.DataAcess.Context;
using Sistema_Votaciones.DataAcess.Repository;

namespace Sistema_Votaciones.BusinessLogic
{
    public static class ServiceConfiguration
    {
        public static void DataAcces(this IServiceCollection service, string conn)
        {
            service.AddScoped<RolesRepository>();
            service.AddScoped<PantallasRepository>();
            service.AddScoped<PantallasPorRolesRepository>();
            service.AddScoped<DepartamentoRepository>();
            service.AddScoped<MunicipioRepository>();
            service.AddScoped<CargosRepository>();
            service.AddScoped<SedesRepository>();
            service.AddScoped<MesasRepository>();
            service.AddScoped<PartidoRepository>();
            service.AddScoped<AlcaldeRepository>();
            service.AddScoped<VotanteRepository>();
            service.AddScoped<VotosPorMesasRepository>();
            service.AddScoped<UsuariosRepository>();
            service.AddScoped<EmpleadosRepository>();
            //service.AddScoped<DispositivoRepository>();
            //service.AddScoped<EmpresaRepository>();
            //service.AddScoped<EstadoCivilRepository>();
            //service.AddScoped<MunicipioRepository>();
            //service.AddScoped<PiezaRepository>();
            //service.AddScoped<ServicioRepository>();
            //service.AddScoped<SolicitudRepository>();
            VotacionesContext.BuildConnectionString(conn);

        }

        public static void BusinessLogic(this IServiceCollection service)
        {
            service.AddScoped<GeneralServices>();
            service.AddScoped<AccesoServices>();
            service.AddScoped<VotacionesServices>();
        }
    }
}
