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
        private readonly BlobStorage _blobStorage;

        public PartidoServicios(API api, BlobStorage blobStorage)
        {
            _api = api;
            _blobStorage = blobStorage;
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
                    req.Path = $"API/Partido/Find?Part_Id={Part_Id}";
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
