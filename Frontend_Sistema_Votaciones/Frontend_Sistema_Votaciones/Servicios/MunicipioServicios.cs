using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class MunicipioServicios
    {
        private readonly API _api;

        public MunicipioServicios(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerMunicipioList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<MunicipioViewModel>, IEnumerable<MunicipioViewModel>>(req =>
                {
                    req.Path = $"API/Municipio/List";
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
        public async Task<ServiceResult> ObtenerMunicipiosList(string Dept_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<MunicipioViewModel>, IEnumerable<MunicipioViewModel>>(req =>
                {
                    req.Path = $"API/Municipio/Find?Dept_Codigo={Dept_Codigo}";
                });
                if (!response.Success)
                {
                    return result.Error(response.Message);
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
        public async Task<ServiceResult> ObtenerMunicipio(string Muni_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<MunicipioViewModel>, MunicipioViewModel>(req =>
                {
                    req.Path = $"API/Municipio/Fill?Muni_Codigo={Muni_Codigo}";
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
        public async Task<ServiceResult> CrearMunicipio(MunicipioViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<MunicipioViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Municipio/Insert";
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
        public async Task<ServiceResult> EditarMunicipio(MunicipioViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<MunicipioViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Municipio/Update";
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

        public async Task<ServiceResult> EliminarMunicipio(string Muni_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<string, ServiceResult>(req =>
                {
                    req.Path = $"API/Municipio/Delete?Muni_Codigo={Muni_Codigo}";
                });

                if (response.Success)
                {
                    return result.Ok($"Municipio {Muni_Codigo} eliminado", response.Data);
                }
                else
                {
                    return result.Error(response.Message);
                }
            }
            catch (Exception ex)
            {
                return result.Error(Helpers.GetMessage(ex));
            }
        }
    }
}
