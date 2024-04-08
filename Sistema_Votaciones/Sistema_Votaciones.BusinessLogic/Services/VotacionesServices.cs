using Sistema_Votaciones.DataAcess.Repository;
using Sistema_Votaciones.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.BusinessLogic.Services
{
   public class VotacionesServices
    {
        private readonly AlcaldeRepository _alcaldeRepository;
        private readonly VotosPorMesasRepository _votosPorMesasRepository;
        private readonly PartidoRepository _partidoRepository;
        private readonly PresidenteRepository _presidenteRepository;

        public VotacionesServices(
               AlcaldeRepository alcaldeRepository,
               VotosPorMesasRepository votosPorMesasRepository,
               PartidoRepository partidoRepository,
               PresidenteRepository presidenteRepository)

        {
            _alcaldeRepository = alcaldeRepository;
            _votosPorMesasRepository = votosPorMesasRepository;
            _partidoRepository = partidoRepository;
            _presidenteRepository = presidenteRepository;
        }


        #region Alcaldes
        public ServiceResult ListAlcalde()
        {
            var result = new ServiceResult();
            try
            {
                var list = _alcaldeRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult BuscarAlcalde(int Alca_Id)
        {
            var result = new ServiceResult();
            try
            {
                var votante = _alcaldeRepository.Find(Alca_Id);
                if (votante != null)
                {
                    return result.Ok(votante);
                }
                else
                {
                    return result.Error($"No se encontró el alcalde con ID {Alca_Id}");
                }
            }
            catch (Exception ex)
            {
                return result.Error($"No se encontró el alcalde con ID {Alca_Id}");
            }
        }
        public ServiceResult CrearAlcalde(tbAlcaldes item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _alcaldeRepository.Insert(item);
                if (response.CodeStatus == 1)
                {
                    return result.Ok("Alcalde creado con exito", response);
                }
                else
                {
                    return result.Error("Por favor rellene todos los campos");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al guardar la informacion del alcalde");
            }
        }

        public ServiceResult EditarAlcalde(tbAlcaldes item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _alcaldeRepository.Update(item);
                if (response.CodeStatus == 1)
                {
                    return result.Ok("Alcalde editado con exito", response);
                }
                else
                {
                    return result.Error("Por favor rellene todos los campos");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al editar la informacion del alcalde");
            }
        }
        public ServiceResult EliminarAlcalde(int Alca_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _alcaldeRepository.Delete(Alca_Id);
                if (list.CodeStatus > 0)
                {
                    return result.Ok(list);
                }
                else
                {
                    list.MessageStatus = (list.CodeStatus == 0) ? "No se encontró el Alcalde a eliminar" : list.MessageStatus;
                    return result.Error(list);
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }

        #endregion

        #region Presidentes
        public ServiceResult ListPresidente()
        {
            var result = new ServiceResult();
            try
            {
                var list = _presidenteRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult CrearPresidente(tbPresidentes item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _presidenteRepository.Insert(item);
                if (response.CodeStatus == 1)
                {
                    return result.Ok("Presidente creado con exito", response);
                }
                else
                {
                    return result.Error("Ya existe un Presidente con ese DNI");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }

        public ServiceResult EditarPresidente(tbPresidentes item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _presidenteRepository.Update(item);
                if (list.CodeStatus > 0)
                {
                    return result.Ok(list);
                }
                else
                {
                    list.MessageStatus = (list.CodeStatus == 0) ? "Ya existe un Presidente con ese nombre" : list.MessageStatus;
                    return result.Error(list);
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult EliminarPresidente(int Pres_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _presidenteRepository.Delete(Pres_Id);
                if (list.CodeStatus > 0)
                {
                    return result.Ok(list);
                }
                else
                {
                    list.MessageStatus = (list.CodeStatus == 0) ? "No se encontró el Presidente a eliminar" : list.MessageStatus;
                    return result.Error(list);
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }

        #endregion


        #region Partidos
        public ServiceResult ListPart()
        {
            var result = new ServiceResult();
            try
            {
                var list = _partidoRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult CrearPart(tbPartidos item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _partidoRepository.Insert(item);
                if (response.CodeStatus == 1)
                {
                    return result.Ok("Partido creado con exito", response);
                }
                else
                {
                    return result.Error("Ya existe un partido con ese con ese nombre");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }

        public ServiceResult EditarPart(tbPartidos item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _partidoRepository.Update(item);
                if (response.CodeStatus == 1)
                {
                    return result.Ok("Partido editado con exito", response);
                }
                else
                {
                    return result.Error("Ya existe un partido con ese con ese nombre");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult DesactivarPartido(int Part_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = _alcaldeRepository.Delete(Part_Id);
                if (response.CodeStatus == 1)
                {
                    return result.Ok("Partido inhabilitado", response);
                }
                else
                {
                    return result.Error("No se puede inhabilitar el partido porque ya tiene votos registrados");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }

        #endregion

        #region VotosPorMesas
        public ServiceResult ListVotosPorMesas()
        {
            var result = new ServiceResult();
            try
            {
                var list = _votosPorMesasRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult ListVotosPorMesasAlcaldes()
        {
            var result = new ServiceResult();
            try
            {
                var list = _votosPorMesasRepository.ListAlcaldes();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult ListVotosPorMesasPresidentes()
        {
            var result = new ServiceResult();
            try
            {
                var list = _votosPorMesasRepository.ListPresidentes();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult CrearVotosPorMesas(tbVotosPorMesas item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _votosPorMesasRepository.Insert(item);
                if (list.CodeStatus > 0)
                {
                    return result.Ok(list);
                }
                else
                {
                    list.MessageStatus = (list.CodeStatus == 0) ? "Ya existe ese Alcalde" : list.MessageStatus;
                    return result.Error(list);
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }

        public ServiceResult EditarVotosPorMesas(tbVotosPorMesas item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _votosPorMesasRepository.Update(item);
                if (list.CodeStatus > 0)
                {
                    return result.Ok(list);
                }
                else
                {
                    list.MessageStatus = (list.CodeStatus == 0) ? "Ya existe un Alcalde con ese nombre" : list.MessageStatus;
                    return result.Error(list);
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult EliminarVotosPorMesas(int VoMe_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _votosPorMesasRepository.Delete(VoMe_Id);
                if (list.CodeStatus > 0)
                {
                    return result.Ok(list);
                }
                else
                {
                    list.MessageStatus = (list.CodeStatus == 0) ? "No se encontró el Alcalde a eliminar" : list.MessageStatus;
                    return result.Error(list);
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        #endregion

        #region Partidos
        public ServiceResult ListPartido()
        {
            var result = new ServiceResult();
            try
            {
                var list = _partidoRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }

        public ServiceResult CrearPartido(tbPartidos item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _partidoRepository.Insert(item);
                if (list.CodeStatus > 0)
                {
                    return result.Ok(list);
                }
                else
                {
                    list.MessageStatus = (list.CodeStatus == 0) ? "Ya existe ese Partido" : list.MessageStatus;
                    return result.Error(list);
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }

        public ServiceResult EditarPartido(tbPartidos item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _partidoRepository.Update(item);
                if (list.CodeStatus > 0)
                {
                    return result.Ok(list);
                }
                else
                {
                    list.MessageStatus = (list.CodeStatus == 0) ? "Ya existe un Partido con ese nombre" : list.MessageStatus;
                    return result.Error(list);
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }

        public ServiceResult EliminarPartido(int Part_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _partidoRepository.Delete(Part_Id);
                if (list.CodeStatus > 0)
                {
                    return result.Ok(list);
                }
                else
                {
                    list.MessageStatus = (list.CodeStatus == 0) ? "No se encontró el Partido a eliminar" : list.MessageStatus;
                    return result.Error(list);
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
