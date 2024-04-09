using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class EmpleadoServicios
    {
        private readonly API _api;

        public EmpleadoServicios(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerEmpleadoList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<EmpleadoViewModel>, IEnumerable<EmpleadoViewModel>>(req =>
                {
                    req.Path = $"API/Empleado/List";
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
        public async Task<ServiceResult> ObtenerEmpleado(int Empl_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<EmpleadoViewModel>, EmpleadoViewModel>(req =>
                {
                    req.Path = $"API/Empleados/Find?Empl_Id={Empl_Id}";
                });
                if (!response.Success)
                {
                    return result.Error("No se encontró el empleado");
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
        public async Task<ServiceResult> CrearEmpleado(EmpleadoViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<EmpleadoViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Empleado/Insert";
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
        public async Task<ServiceResult> EditarEmpleado(EmpleadoViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<EmpleadoViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Empleado/Update";
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

        public async Task<ServiceResult> EliminarEmpleado(string Empl_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<string, ServiceResult>(req =>
                {
                    req.Path = $"API/Empleado/Delete?Empl_Id={Empl_Id}";
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
