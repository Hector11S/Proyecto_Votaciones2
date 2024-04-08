using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.WebAPI;
using Sistema_Votaciones.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class EstadosCivilesServicios
    {
        private readonly API _api;

        public EstadosCivilesServicios(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerEstadosCivilesList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<EstadosCivilesViewModel>, IEnumerable<EstadosCivilesViewModel>>(req =>
                {
                    req.Path = $"API/EstadosCiviles/List";
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
        public async Task<ServiceResult> ObtenerEstadosCiviles(int Esta_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<EstadosCivilesViewModel>, EstadosCivilesViewModel>(req =>
                {
                    req.Path = $"API/EstadosCiviles/Find?Esta_Id={Esta_Id}";
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
        public async Task<ServiceResult> CrearEstadosCiviles(EstadosCivilesViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<EstadosCivilesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/EstadosCiviles/Insert";
                    req.Content = item;
                });
                if (!response.Success)
                {
                    return result.Error(response.Message);
                }
                else
                {
                    return result.Ok(response.Message, response.Data);
                }
            }
            catch (Exception ex)
            {
                return result.Error(Helpers.GetMessage(ex));
                throw;
            }
        }
        public async Task<ServiceResult> EditarEstadosCiviles(EstadosCivilesViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<EstadosCivilesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/EstadosCiviles/Update";
                    req.Content = item;
                });
                if (!response.Success)
                {
                    return result.Error(response.Message);
                }
                else
                {
                    return result.Ok(response.Message, response.Data);
                }
            }
            catch (Exception ex)
            {
                return result.Error(Helpers.GetMessage(ex));
                throw;
            }
        }

        public async Task<ServiceResult> EliminarEstadosCiviles(string Esta_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<string, ServiceResult>(req =>
                {
                    req.Path = $"API/EstadosCiviles/Delete?Esta_Id={Esta_Id}";
                });

                if (!response.Success)
                {
                    return result.Error(response.Message);
                }
                else
                {
                    return result.Ok(response.Message, response.Data);
                }
            }
            catch (Exception ex)
            {
                return result.Error(Helpers.GetMessage(ex));
            }
        }
    }
}
