using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.WebAPI;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class RolesServicios
    {
        private readonly API _api;

        public RolesServicios(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerRolesList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<RolesViewModel>, IEnumerable<RolesViewModel>>(req =>
                {
                    req.Path = $"API/Roles/List";
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

        public async Task<ServiceResult> ObtenerRoles(int Rol_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<RolesViewModel>, RolesViewModel>(req =>
                {
                    req.Path = $"API/Roles/Find?Rol_Id={Rol_Id}";
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
        public async Task<ServiceResult> CrearRoles(RolesViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<RolesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Roles/Insert";
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
        public async Task<ServiceResult> EditarRoles(RolesViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<RolesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Roles/Update";
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

        public async Task<ServiceResult> EliminarRoles(string Dept_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<string, ServiceResult>(req =>
                {
                    req.Path = $"API/Roles/Delete?Dept_Codigo={Dept_Codigo}";
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
