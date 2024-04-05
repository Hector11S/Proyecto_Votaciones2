using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class VotosPorMesaServicios
    {
        private readonly API _api;

        public VotosPorMesaServicios(API api)
        {
            _api = api;
        }


        public async Task<ServiceResult> VotosPorMesaList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<VotosPorMesasViewModel>, IEnumerable<VotosPorMesasViewModel>>(req =>
                {
                    req.Path = $"API/votosPorMesas/List";
                });
                if (response != null && !response.Success)
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
        public async Task<ServiceResult> ObtenerVotosPorMesa(int VoMe_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<VotosPorMesasViewModel>, VotosPorMesasViewModel>(req =>
                {
                    req.Path = $"API/votosPorMesas/Fill?VoMe_Id={VoMe_Id}";
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
        public async Task<ServiceResult> CrearVotosPorMesa(VotosPorMesasViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<VotosPorMesasViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/votosPorMesas/Insert";
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
        public async Task<ServiceResult> EditarVotosPorMesa(VotosPorMesasViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<VotosPorMesasViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/votosPorMesas/Update";
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

        public async Task<ServiceResult> EliminarVotosPorMesa(int VoMe_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<int, ServiceResult>(req =>
                {
                    req.Path = $"API/votosPorMesas/Delete?VoMe_Id={VoMe_Id}";
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
