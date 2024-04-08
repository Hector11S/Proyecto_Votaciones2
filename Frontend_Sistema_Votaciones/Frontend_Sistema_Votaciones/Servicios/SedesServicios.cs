using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.WebAPI;
using Sistema_Votaciones.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class SedesServicios
    {
        private readonly API _api;

        public SedesServicios(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerSedesList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<SedesViewModel>, IEnumerable<SedesViewModel>>(req =>
                {
                    req.Path = $"API/Sedes/List";
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
        public async Task<ServiceResult> ObtenerSedes(int Sede_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<SedesViewModel>, SedesViewModel>(req =>
                {
                    req.Path = $"API/Sedes/Find?Sede_Id={Sede_Id}";
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
        public async Task<ServiceResult> CrearSedes(SedesViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<SedesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Sedes/Insert";
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
        public async Task<ServiceResult> EditarSedes(SedesViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<SedesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Sedes/Update";
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

        public async Task<ServiceResult> EliminarSedes(string Sede_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<string, ServiceResult>(req =>
                {
                    req.Path = $"API/Sedes/Delete?Sede_Id={Sede_Id}";
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
