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

        public async Task<ServiceResult> VotosPorMesaListAlcaldes(string Muni_Codigo)
        {
            var result = new ServiceResult();
            try
            {
    
                if (string.IsNullOrEmpty(Muni_Codigo))
                {
                    return result.Error("Se necesita un municipio seleccionado para obtener los votos por mesas de los alcaldes.");
                }

                var response = await _api.Get<IEnumerable<VotosPorMesasViewModel>, IEnumerable<VotosPorMesasViewModel>>(req =>
                {
                    req.Path = $"API/votosPorMesas/ListAlcaldesPorMunicipio?Muni_Codigo={Muni_Codigo}";
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
            }
        }




        public async Task<ServiceResult> VotosPorMesaListPresidentes()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<VotosPorMesasViewModel>, IEnumerable<VotosPorMesasViewModel>>(req =>
                {
                    req.Path = $"API/votosPorMesas/ListPresidentes";
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

        public async Task<ServiceResult> VotosPorMesaListPorMunicipio(string municipioId)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<VotosPorMesasViewModel>, IEnumerable<VotosPorMesasViewModel>>(req =>
                {
                    req.Path = $"API/votosPorMesas/ListPorMunicipio?municipioId={municipioId}";
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



    }
}
