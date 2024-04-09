using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class CargoServicios
    {
        private readonly API _api;

        public CargoServicios(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerCargoList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<CargoViewModel>, IEnumerable<CargoViewModel>>(req =>
                {
                    req.Path = $"API/Cargos/List";
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
        public async Task<ServiceResult> ObtenerCargo(int Carg_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<CargoViewModel>, CargoViewModel>(req =>
                {
                    req.Path = $"API/Cargos/Find?Carg_Id={Carg_Id}";
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
        public async Task<ServiceResult> CrearCargo(CargoViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<CargoViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Cargos/Insert";
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
        public async Task<ServiceResult> EditarCargo(CargoViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<CargoViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Cargos/Update";
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

        public async Task<ServiceResult> EliminarCargo(string Carg_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<string, ServiceResult>(req =>
                {
                    req.Path = $"API/Cargos/Delete?Carg_Id={Carg_Id}";
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
