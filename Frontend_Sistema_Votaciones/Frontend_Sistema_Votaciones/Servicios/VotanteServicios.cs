using Frontend_Sistema_Votaciones.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class VotanteServicios
    {

        private readonly API _api;

        public VotanteServicios(API api)
        {
            _api = api;
        }

        public async Task<bool> ExisteVotante(string dni)
        {
            try
            {
                var response = await _api.Get<bool, bool>(req =>
                {
                    req.Path = $"API/Votante/ExisteVotante?dni={dni}";
                });
                return response.Data;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
