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

        public VotacionesServices(
               AlcaldeRepository alcaldeRepository,
               VotosPorMesasRepository votosPorMesasRepository,
               PartidoRepository partidoRepository)

        {
            _alcaldeRepository = alcaldeRepository;
            _votosPorMesasRepository = votosPorMesasRepository;
            _partidoRepository = partidoRepository;
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
        public ServiceResult CrearAlcalde(tbAlcaldes item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _alcaldeRepository.Insert(item);
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

        public ServiceResult EditarAlcalde(tbAlcaldes item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _alcaldeRepository.Update(item);
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
