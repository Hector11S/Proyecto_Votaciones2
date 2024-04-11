using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class PantallasPorRolesServicios
    {
        private readonly API _api;

        public PantallasPorRolesServicios(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerParoList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<PantallasPorRolesViewModel>, IEnumerable<PantallasPorRolesViewModel>>(req =>
                {
                    req.Path = $"API/PantallasPorRoles/List";
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
        public async Task<ServiceResult> ObtenerParoList(int Rol_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<PantallasPorRolesViewModel>, IEnumerable<PantallasPorRolesViewModel>>(req =>
                {
                    req.Path = $"API/PantallasPorRoles/Find?Rol_Id={Rol_Id}";
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

        public async Task<ServiceResult> CrearParo(PantallasPorRolesViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<PantallasPorRolesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/PantallasPorRoles/Insert";
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

        public async Task<ServiceResult> EliminarParo(int Rol_Id, int Pant_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<string, ServiceResult>(req =>
                {
                    req.Path = $"API/PantallasPorRoles/Delete?Rol_Id={Rol_Id}&Pant_Id={Pant_Id}";
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



        public async Task<ServiceResult> CrearParoPorEsqu(PantallasPorRolesViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<PantallasPorRolesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/PantallasPorRoles/CreatePorEsqu";
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

        public async Task<ServiceResult> EliminarParoPorEsqu(int Rol_Id, int Esqu_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<string, ServiceResult>(req =>
                {
                    req.Path = $"API/PantallasPorRoles/DeletePorEsqu?Rol_Id={Rol_Id}&Esqu_Id={Esqu_Id}";
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
