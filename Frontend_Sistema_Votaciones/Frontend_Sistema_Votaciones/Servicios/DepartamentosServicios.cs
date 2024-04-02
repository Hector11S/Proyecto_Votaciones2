using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend_Sistema_Votaciones.Models;

namespace Frontend_Sistema_Votaciones.Servicios
{
    public class DepartamentosServicios
    {
        public async Task<ServiceResult> DepartamentosList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<DepartamentoViewModel>, IEnumerable<DepartamentoViewModel>>(req =>
                {
                    req.Path = $"API/Departamentos/List";
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
