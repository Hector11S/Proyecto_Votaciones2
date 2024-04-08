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
        private readonly CargosRepository _cargosRepository;
        private readonly SedesRepository _sedesRepository;
        private readonly EstadosCivilesRepository _estadosCivilesRepository;
        private readonly MesasRepository _mesasRepository;
        private readonly EmpleadosRepository _empleadosRepository;
        private readonly VotanteRepository _votanteRepository;

        public GeneralServices(
               DepartamentoRepository departamentosRepository,
               MunicipioRepository municipioRepository,
               CargosRepository cargosRepository,
               SedesRepository sedesRepository,
               EstadosCivilesRepository estadosCivilesRepository,
               MesasRepository mesasRepository,
               EmpleadosRepository empleadosRepository,
               VotanteRepository votanteRepository)

        {
            _departamentosRepository = departamentosRepository;
            _municipioRepository = municipioRepository;
            _cargosRepository = cargosRepository;
            _sedesRepository = sedesRepository;
            _estadosCivilesRepository = estadosCivilesRepository;
            _empleadosRepository = empleadosRepository;
            _mesasRepository = mesasRepository;
            _empleadosRepository = empleadosRepository;
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
                return result.Error("Error al cargar el municipios");
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

        #region Cargos
        public ServiceResult ListCargo()
        {
            var result = new ServiceResult();
            try
            {
                var list = _cargosRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult ListCargo(int Carg_Id)
        {
            var result = new ServiceResult();
            try
            {
                var cargo = _cargosRepository.Find(Carg_Id);
                if (cargo != null)
                {
                    return result.Ok(cargo);
                }
                else
                {
                    return result.Error("No se encontró el cargo");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al cargar el cargo");
            }
        }
        public ServiceResult CrearCargo(tbCargos item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _cargosRepository.Insert(item);
                if (response.CodeStatus == 1)
                {
                    return result.Ok("Cargo creado con exito", response);
                }
                else
                {
                    return result.Error("Ya existe un cargo con ese nombre");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult EditarCargo(tbCargos item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _cargosRepository.Update(item);
                if (response.CodeStatus == 1)
                {
                    return result.Ok($"Cargo {item.Carg_Id} editado con éxito", response);
                }
                else
                {
                    return result.Error("Ya existe un cargo con ese nombre");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult EliminarCargo(int Carg_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = _cargosRepository.Delete(Carg_Id);
                if (response.CodeStatus == 1)
                {
                    return result.Ok($"Cargo {Carg_Id} eliminado con éxito", response);
                }
                else
                {
                    return result.Error("Hay empleados que dependen de este cargo");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        #endregion

        #region Empleados
        public ServiceResult ListEmpl()
        {
            var result = new ServiceResult();
            try
            {
                var list = _empleadosRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error al cargar los empleados");
            }
        }
        public ServiceResult FindEmpl(int Empl_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _empleadosRepository.Find(Empl_Id);

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error al cargar el empleado");
            }
        }
        public ServiceResult CrearEmpl(tbEmpleados item)
        {
            var result = new ServiceResult();
            try
            {
                var reponse = _empleadosRepository.Insert(item);
                if (reponse.CodeStatus == 1)
                {
                    return result.Ok("Empleado creado con exito", reponse);
                }
                else
                {
                    return result.Error("Por favor rellene todos los campos");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al crear el empleado");
            }
        }
        public ServiceResult EditarEmpl(tbEmpleados item)
        {
            var result = new ServiceResult();
            try
            {
                var reponse = _empleadosRepository.Update(item);
                if (reponse.CodeStatus == 1)
                {
                    return result.Ok($"Empleado {item.Empl_Id} editado con éxito", reponse);
                }
                else
                {
                    return result.Error("Por favor rellene todos los campos");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al editar el empleado");
            }
        }
        public ServiceResult ActivarDesactivarEmpl(int Empl_Id)
        {
            var result = new ServiceResult();
            try
            {
                var reponse = _empleadosRepository.Update(Empl_Id);
                if (reponse.CodeStatus == 1)
                {
                    return result.Ok($"Empleado {Empl_Id} actualizado", reponse);
                }
                else
                {
                    return result.Error("Error al actualizar el empleado");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al actualizar el empleado");
            }
        }
        #endregion

        #region EstadosCiviles
        public ServiceResult ListEsta()
        {
            var result = new ServiceResult();
            try
            {
                var list = _estadosCivilesRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error al cargar los estados civiles");
            }
        }
        public ServiceResult ListEsta(int Esta_Id)
        {
            var result = new ServiceResult();
            try
            {
                var esta = _estadosCivilesRepository.Find(Esta_Id);
                if (esta != null)
                {
                    return result.Ok(esta);
                }
                else
                {
                    return result.Error("No se encontró el estado civil");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al cargar el estado civil");
            }
        }
        public ServiceResult CrearEsta(tbEstadosCiviles item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _estadosCivilesRepository.Insert(item);
                if (response.CodeStatus == 1)
                {
                    return result.Ok("Estado civil creada con exito", response);
                }
                else
                {
                    return result.Error("Ya existe un estado civil con ese nombre");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al crear el estado civil");
            }
        }
        public ServiceResult EditarEsta(tbEstadosCiviles item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _estadosCivilesRepository.Update(item);
                if (response.CodeStatus == 1)
                {
                    return result.Ok($"Estado civil {item.Esta_Id} editado con éxito", response);
                }
                else
                {
                    return result.Error("Ya existe un estado civil con ese nombre");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al editar el estado civil");
            }
        }
        public ServiceResult EliminarEsta(int Esta_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = _estadosCivilesRepository.Delete(Esta_Id);
                if (response.CodeStatus == 1)
                {
                    return result.Ok($"Estado civil {Esta_Id} eliminada con éxito", response);
                }
                else
                {
                    return result.Error("Hay personas que tienen este estado civil registrado");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al eliminar el estado civil");
            }
        }
        #endregion

        #region Sedes
        public ServiceResult ListSede()
        {
            var result = new ServiceResult();
            try
            {
                var list = _sedesRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult ListSede(int Sede_Id)
        {
            var result = new ServiceResult();
            try
            {
                var cargo = _sedesRepository.Find(Sede_Id);
                if (cargo != null)
                {
                    return result.Ok(cargo);
                }
                else
                {
                    return result.Error("No se encontró la sede");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al cargar la sede");
            }
        }
        public ServiceResult CrearSede(tbSedes item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _sedesRepository.Insert(item);
                if (response.CodeStatus == 1)
                {
                    return result.Ok("Sede creada con exito", response);
                }
                else
                {
                    return result.Error("Ya existe una sede con ese nombre");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al crear la sede");
            }
        }
        public ServiceResult EditarSede(tbSedes item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _sedesRepository.Update(item);
                if (response.CodeStatus == 1)
                {
                    return result.Ok($"Sede {item.Sede_Id} editada con éxito", response);
                }
                else
                {
                    return result.Error("Ya existe una sede con ese nombre");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al editar la sede");
            }
        }
        public ServiceResult EliminarSede(int Sede_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = _sedesRepository.Delete(Sede_Id);
                if (response.CodeStatus == 1)
                {
                    return result.Ok($"Sede {Sede_Id} eliminada con éxito", response);
                }
                else
                {
                    return result.Error("Hay mesas que dependen de esta sede o personas que se les asignó esta sede para votar");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al eliminar la sede");
            }
        }
        #endregion

        #region Mesas
        public ServiceResult ListMesa()
        {
            var result = new ServiceResult();
            try
            {
                var list = _mesasRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error al cargar las mesas");
            }
        }
        public ServiceResult ListMesa(int Mesa_Id)
        {
            var result = new ServiceResult();
            try
            {
                var mesa = _mesasRepository.Find(Mesa_Id);
                if (mesa != null)
                {
                    return result.Ok(mesa);
                }
                else
                {
                    return result.Error("No se encontró la mesa");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al cargar la mesa");
            }
        }
        public ServiceResult CrearMesa(tbMesas item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _mesasRepository.Insert(item);
                if (response.CodeStatus == 1)
                {
                    return result.Ok("Mesa creada con exito", response);
                }
                else
                {
                    return result.Error("Ya existe una mesa con ese numero");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al crear la mesa");
            }
        }
        public ServiceResult EditarMesa(tbMesas item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _mesasRepository.Update(item);
                if (response.CodeStatus == 1)
                {
                    return result.Ok($"Mesa {item.Mesa_Id} editada con éxito", response);
                }
                else
                {
                    return result.Error("Ya existe una mesa con ese numero");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al editar la mesa");
            }
        }
        public ServiceResult EliminarMesa(int Mesa_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = _mesasRepository.Delete(Mesa_Id);
                if (response.CodeStatus == 1)
                {
                    return result.Ok($"Mesa {Mesa_Id} eliminada con éxito", response);
                }
                else
                {
                    return result.Error("Hay personas que se les asignó esta mesa para votar");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al eliminar la mesa");
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
                return result.Error("Error al cargar los votantes");
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
        #endregion
    }
}
