using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class PantallasServicios
    {
        private readonly API _api;

        public PantallasServicios(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerPantallasList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<PantallasViewModel>, IEnumerable<PantallasViewModel>>(req =>
                {
                    req.Path = $"API/Pantallas/List";
                });
                if (!response.Success)
                {
                    return result.FromApi(response);
                }
                else
                {
                    return result.Ok(response.Data);
                }
            }
            catch (Exception ex)
            {
                return result.Error(Helpers.GetMessage(ex));
                throw;
            }
        }
    }
}
