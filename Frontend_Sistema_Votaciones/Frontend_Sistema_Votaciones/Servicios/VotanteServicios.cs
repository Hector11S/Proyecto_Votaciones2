﻿using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class VotanteServicios
    {
        private readonly API _api;
        private readonly BlobStorage _blobStorage;

        public VotanteServicios(API api, BlobStorage blobStorage)
        {
            _api = api;
            _blobStorage = blobStorage;
        }
        public async Task<ServiceResult> ObtenerVotanteList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<VotanteViewModel>, IEnumerable<VotanteViewModel>>(req =>
                {
                    req.Path = $"API/Votante/List";
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
        public async Task<ServiceResult> ObtenerVotantePorDNI(string Vota_DNI)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<VotanteViewModel>, VotanteViewModel>(req =>
                {
                    req.Path = $"API/Votante/Find?Vota_DNI={Vota_DNI}";
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
        public async Task<ServiceResult> CrearVotante(VotanteViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<VotanteViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Votante/Insert";
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
        public async Task<ServiceResult> EditarVotante(VotanteViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<VotanteViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Votante/Update";
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
    }
}
