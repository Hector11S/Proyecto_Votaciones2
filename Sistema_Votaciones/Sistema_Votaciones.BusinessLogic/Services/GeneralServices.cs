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


        public GeneralServices(
               DepartamentoRepository departamentosRepository)

        {
            _departamentosRepository = departamentosRepository;

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
        public ServiceResult CrearDepto(tbDepartamentos item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _departamentosRepository.Insert(item);
                if (list.CodeStatus > 0)
                {
                    return result.Ok(list);
                }
                else
                {
                    list.MessageStatus = (list.CodeStatus == 0) ? "Ya existe ese departamento" : list.MessageStatus;
                    return result.Error(list);
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
                    return result.Ok(list);
                }
                else
                {
                    list.MessageStatus = (list.CodeStatus == 0) ? "Ya existe un departamento con ese nombre" : list.MessageStatus;
                    return result.Error(list);
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
                    return result.Ok(list);
                }
                else
                {
                    list.MessageStatus = (list.CodeStatus == 0) ? "No se encontró el departamento a eliminar" : list.MessageStatus;
                    return result.Error(list);
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        //public IEnumerable<tbMunicipios> ObtenerDeptoID(string Dept_Id)
        //{
        //    return _departamentosRepository.GetMunicipiosPorDepartamento(Dept_Id);
        //}

        //public tbDepartamentos ObtenerDetallesDepto(string Dept_Id)
        //{
        //    return _departamentosRepository.GetById(Dept_Id);
        //}


        //public IEnumerable<tbMunicipios> ObtenerMunicipiosPorDepartamento(string Dept_Id)
        //{
        //    return _departamentosRepository.GetMunicipiosPorDepartamento(Dept_Id);
        //}


        //public IEnumerable<tbMunicipios> ObtenerMunicipiosPorDepartamento(string Dept_Id)
        //{
        //    try
        //    {

        //        return _municipioRepository.ObtenerMunicipiosPorDepartamento(Dept_Id);
        //    }
        //    catch (Exception ex)
        //    {

        //        return Enumerable.Empty<tbMunicipios>();
        //    }
        //}
        #endregion

    }
}
