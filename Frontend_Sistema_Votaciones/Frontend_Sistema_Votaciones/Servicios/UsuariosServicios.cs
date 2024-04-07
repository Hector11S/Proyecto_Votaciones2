using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.WebAPI;
using Sistema_Votaciones.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class UsuariosServicios
    {
        private readonly API _api;

        public UsuariosServicios(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerUsuariosList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<UsuariosViewModel>, IEnumerable<UsuariosViewModel>>(req =>
                {
                    req.Path = $"API/Usuarios/List";
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

        public async Task<ServiceResult> ObtenerUsuarios(string Usua_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<DepartamentoViewModel>, DepartamentoViewModel>(req =>
                {
                    req.Path = $"API/Usuarios/Find?Usua_Id={Usua_Id}";
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


        public async Task<ServiceResult> CrearUsuarios(UsuariosViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<UsuariosViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Usuarios/Insert";
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
        public async Task<ServiceResult> EditarUsuarios(UsuariosViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<UsuariosViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Usuarios/Update";
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

        public async Task<ServiceResult> EliminarUsuarios(string Dept_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<string, ServiceResult>(req =>
                {
                    req.Path = $"API/Usuarios/Delete?Dept_Codigo={Dept_Codigo}";
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
