using Azure.Storage.Blobs;
using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.WebAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class PresidenteServicios
    {
        private readonly API _api;
        private readonly BlobStorage _blobStorage;

        public PresidenteServicios(API api, BlobStorage blobStorage)
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
        public async Task<ServiceResult> ObtenerPresidenteList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<PresidenteViewModel>, IEnumerable<PresidenteViewModel>>(req =>
                {
                    req.Path = $"API/Presidente/List";
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
        public async Task<ServiceResult> ObtenerPresidente(string Pres_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<PresidenteViewModel>, PresidenteViewModel>(req =>
                {
                    req.Path = $"API/Presidente/Fill?Pres_Id={Pres_Id}";
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
        public async Task<ServiceResult> CrearPresidente(PresidenteViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<PresidenteViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Presidente/Insert";
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
        public async Task<ServiceResult> EditarPresidente(PresidenteViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<PresidenteViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Presidente/Update";
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

        public async Task<ServiceResult> EliminarPresidente(int Pres_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<string, ServiceResult>(req =>
                {
                    req.Path = $"API/Presidente/Delete?Pres_Id={Pres_Id}";
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
