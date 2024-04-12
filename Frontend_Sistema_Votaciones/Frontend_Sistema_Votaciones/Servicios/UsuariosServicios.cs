using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class UsuariosServicios
    {
        private readonly API _api;
        private readonly BlobStorage _blobStorage;

        public UsuariosServicios(API api, BlobStorage blobStorage)
        {
            _api = api;
            _blobStorage = blobStorage;
        }
        public async Task<ServiceResult> IniciarSesion(UsuariosViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<UsuariosViewModel, UsuariosViewModel>(req =>
                {
                    req.Path = $"API/Usuarios/IniciarSesion";
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
        public async Task<ServiceResult> SubirImagen(string localFilePath)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _blobStorage.SubirImagen(localFilePath);
                var statusCode = response.GetRawResponse().Status;
                if (statusCode != 201)
                {
                    return result.Error("Error, no se pudo guardar la imagen");
                }
                else
                {
                    return result.Ok("Imagen guardada", _blobStorage.ObtenerUrlImagen(localFilePath));
                }
            }
            catch (Exception ex)
            {
                return result.Error(Helpers.GetMessage(ex));
                throw;
            }
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
        
        public async Task<ServiceResult> ObtenerUsuarioPorEmplId(int Empl_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<UsuariosViewModel>, UsuariosViewModel>(req =>
                {
                    req.Path = $"API/Usuarios/FindByEmpl?Empl_Id={Empl_Id}";
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

        public async Task<ServiceResult> ObtenerUsuario(string Usua_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<UsuariosViewModel>, UsuariosViewModel>(req =>
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
    }
}
