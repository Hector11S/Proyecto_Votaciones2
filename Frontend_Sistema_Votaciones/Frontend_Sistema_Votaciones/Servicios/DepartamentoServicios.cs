using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.WebAPI;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class DepartamentoServicios
    {
        private readonly API _api;

        public DepartamentoServicios(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerDepartamentoList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<DepartamentoViewModel>, IEnumerable<DepartamentoViewModel>>(req =>
                {
                    req.Path = $"API/Departamento/List";
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
        public async Task<ServiceResult> ObtenerDepartamento(string Dept_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<DepartamentoViewModel>, DepartamentoViewModel>(req =>
                {
                    req.Path = $"API/Departamento/Fill?Dept_Codigo={Dept_Codigo}";
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
        public async Task<ServiceResult> CrearDepartamento(DepartamentoViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<DepartamentoViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Departamento/Insert";
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

        public async Task<ServiceResult> EliminarDepartamento(string Dept_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<string, ServiceResult>(req =>
                {
                    req.Path = $"API/Departamento/Delete?Dept_Codigo={Dept_Codigo}";
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
