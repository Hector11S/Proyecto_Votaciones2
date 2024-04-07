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
        private readonly MunicipioRepository _municipioRepository;
        private readonly VotanteRepository _votanteRepository;

        public GeneralServices(
               DepartamentoRepository departamentosRepository,
               MunicipioRepository municipioRepository,
               VotanteRepository votanteRepository)

        {
            _departamentosRepository = departamentosRepository;
            _municipioRepository = municipioRepository;
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
                var reponse = _departamentosRepository.Insert(item);
                if (reponse.CodeStatus == 1)
                {
                    return result.Ok("Departamento creado con exito", reponse);
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
                var reponse = _departamentosRepository.Update(item);
                if (reponse.CodeStatus == 1)
                {
                    return result.Ok($"Departamento {item.Dept_Codigo} editado con éxito", reponse);
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
                var reponse = _departamentosRepository.Delete(Dept_Codigo);
                if (reponse.CodeStatus == 1)
                {
                    return result.Ok($"Departamento {Dept_Codigo} eliminado con éxito", reponse);
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

        #region Municipios
        public ServiceResult ListMuni()
        {
            var result = new ServiceResult();
            try
            {
                var list = _municipioRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult ListMuni(string Dept_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var list = _municipioRepository.List(Dept_Codigo);
                if (list.Count > 0)
                {
                    return result.Ok(list);
                }
                else
                {
                    return result.Error("No se encontraron municipios");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al cargar los municipios");
            }
        }
        public ServiceResult CrearMuni(tbMunicipios item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _municipioRepository.Insert(item);
                if (response.CodeStatus == 1)
                {
                    return result.Ok("Municipio creado con exito", response);
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
        public ServiceResult EditarMuni(tbMunicipios item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _municipioRepository.Update(item);
                if (response.CodeStatus == 1)
                {
                    return result.Ok($"Municipio {item.Muni_Codigo} editado con éxito", response);
                }
                else
                {
                    return result.Error("Ya existe un municipio con ese nombre");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult EliminarMuni(string Muni_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var response = _municipioRepository.Delete(Muni_Codigo);
                if (response.CodeStatus == 1)
                {
                    return result.Ok($"Municipio {Muni_Codigo} eliminado con éxito", response);
                }
                else
                {
                    return result.Error("Hay personas, sedes o alcaldes que se postularon que dependen de este municipio");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        #endregion


        #region Votantes
        public ServiceResult ListVotante()
        {
            var result = new ServiceResult();
            try
            {
                var list = _votanteRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult BuscarVotantePorDNI(string Vota_DNI)
        {
            var result = new ServiceResult();
            try
            {
                var votante = _votanteRepository.Find(Vota_DNI);
                if (votante != null)
                {
                    return result.Ok(votante);
                }
                else
                {
                    return result.Error("No se encontró una persona con ese DNI");
                }
            }
            catch (Exception ex)
            {
                return result.Error("No se encontró una persona con ese DNI");
            }
        }
        public ServiceResult CrearVotante(tbVotantes item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _votanteRepository.Insert(item);
                if (response.CodeStatus > 0)
                {
                    return result.Ok("Persona agregada con exito", response);
                }
                else
                {
                    return result.Error("Ya existe un registro de esta persona");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult EditarVotante(tbVotantes item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _votanteRepository.Update(item);
                if (response.CodeStatus == 1)
                {
                    return result.Ok($"Persona {item.Muni_Codigo} editada con éxito", response);
                }
                else
                {
                    return result.Error("Ya existe una persona con ese DNI");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult EliminarVotante(int Vota_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _votanteRepository.Delete(Vota_Id);
                if (list.CodeStatus > 0)
                {
                    return result.Ok($"Departamento {Vota_Id} eliminado con éxito", list);
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
    }
}
