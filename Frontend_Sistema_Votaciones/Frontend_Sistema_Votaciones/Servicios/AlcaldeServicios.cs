using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class AlcaldeServicios
    {
        private readonly API _api;

        public AlcaldeServicios(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerAlcaldeList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<AlcaldeViewModel>, IEnumerable<AlcaldeViewModel>>(req =>
                {
                    req.Path = $"API/Alcalde/List";
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
        public async Task<ServiceResult> ObtenerAlcalde(string Alca_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<AlcaldeViewModel>, AlcaldeViewModel>(req =>
                {
                    req.Path = $"API/Alcalde/Fill?Alca_Id={Alca_Id}";
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
        public async Task<ServiceResult> CrearAlcalde(AlcaldeViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<AlcaldeViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Alcalde/Insert";
                    req.Content = item;
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
        public async Task<ServiceResult> EditarAlcalde(AlcaldeViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<AlcaldeViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Alcalde/Update";
                    req.Content = item;
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
