using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.WebAPI;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class PartidoServicios
    {
        private readonly API _api;

        public PartidoServicios(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerPartidoList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<PartidoViewModel>, IEnumerable<PartidoViewModel>>(req =>
                {
                    req.Path = $"API/Partido/List";
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
        public async Task<ServiceResult> ObtenerPartido(string Part_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<PartidoViewModel>, PartidoViewModel>(req =>
                {
                    req.Path = $"API/Partido/Fill?Part_Id={Part_Id}";
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
        public async Task<ServiceResult> CrearPartido(PartidoViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<PartidoViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Partido/Insert";
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
        public async Task<ServiceResult> EditarPartido(PartidoViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<PartidoViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Partido/Update";
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

        public async Task<ServiceResult> EliminarPartido(int Part_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<int, ServiceResult>(req =>
                {
                    req.Path = $"API/Partido/Delete?Part_Id={Part_Id}";
                });

                if (response.Success)
                {
                    return result.Ok(response.Data);
                }
                else
                {
                    return result.FromApi(response);
                }
            }
            catch (Exception ex)
            {
                return result.Error(Helpers.GetMessage(ex));
            }
        }
    }
}
