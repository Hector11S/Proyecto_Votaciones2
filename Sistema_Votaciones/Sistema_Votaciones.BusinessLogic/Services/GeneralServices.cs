using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema_Votaciones.DataAcess.Repository;
using Sistema_Votaciones.Entities.Entities;

namespace Sistema_Votaciones.BusinessLogic.Services
{
   public class GeneralServices
    {

        private readonly DepartamentoRepository _departamentosRepository;
        private readonly VotanteRepository _votanteRepository;

        public GeneralServices(
               DepartamentoRepository departamentosRepository,
               VotanteRepository votanteRepository)

        {
            _departamentosRepository = departamentosRepository;
            _votanteRepository = votanteRepository;
        }


        #region Departamentos
        public ServiceResult ListDepto()
        {
            var result = new ServiceResult();
            try
            {
                var list = _departamentosRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult ListDepto(string Dept_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var list = _departamentosRepository.List(Dept_Codigo);

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult CrearDepto(tbDepartamentos item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _departamentosRepository.Insert(item);
                if (list.CodeStatus > 0)
                {
                    return result.Ok("Departamento creado con exito", list);
                }
                else
                {
                    return result.Error("Ya existe un departamento con ese codigo o con ese nombre");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult EditarDepto(tbDepartamentos item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _departamentosRepository.Update(item);
                if (list.CodeStatus > 0)
                {
                    return result.Ok($"Departamento {item.Dept_Codigo} editado con éxito", list);
                }
                else
                {
                    return result.Error("Ya existe un departamento con ese nombre");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult EliminarDepto(string Dept_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var list = _departamentosRepository.Delete(Dept_Codigo);
                if (list.CodeStatus > 0)
                {
                    return result.Ok($"Departamento {Dept_Codigo} eliminado con éxito", list);
                }
                else
                {
                    return result.Error("No se encontró el departamento a eliminar");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        #endregion
        #region Votantes
        public ServiceResult FindVotante(string Vota_DNI)
        {
            var result = new ServiceResult();
            try
            {
                var votante = _votanteRepository.Find(Vota_DNI);

                return result.Ok(votante);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        #endregion
    }
}
