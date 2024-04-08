using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.WebAPI;
using Sistema_Votaciones.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class MesasServicios
    {
        private readonly API _api;

        public MesasServicios(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerMesasList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<MesasViewModel>, IEnumerable<MesasViewModel>>(req =>
                {
                    req.Path = $"API/Mesas/List";
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
        public async Task<ServiceResult> ObtenerMesas(int Mesa_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<MesasViewModel>, MesasViewModel>(req =>
                {
                    req.Path = $"API/Mesas/Find?Mesa_Id={Mesa_Id}";
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
        public async Task<ServiceResult> CrearMesas(MesasViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<MesasViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Mesas/Insert";
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
        public async Task<ServiceResult> EditarMesas(MesasViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<MesasViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Mesas/Update";
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

        public async Task<ServiceResult> EliminarMesas(string Mesa_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<string, ServiceResult>(req =>
                {
                    req.Path = $"API/Mesas/Delete?Mesa_Id={Mesa_Id}";
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
