using Sistema_Votaciones.DataAcess.Repository;
using Sistema_Votaciones.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.BusinessLogic.Services
{
    public class AccesoServices
    {
        private readonly UsuariosRepository _usuariosRepository;
        private readonly PantallasRepository _pantallasRepository;
        private readonly RolesRepository _rolesRepository;
        private readonly PantallasPorRolesRepository _pantallasPorRolesRepository;
        public AccesoServices(
            UsuariosRepository usuariosRepository,
            PantallasRepository pantallasRepository,
            RolesRepository rolesRepository,
            PantallasPorRolesRepository pantallasPorRolesRepository)
        {
            _usuariosRepository = usuariosRepository;
            _pantallasRepository = pantallasRepository;
            _pantallasPorRolesRepository = pantallasPorRolesRepository;
            _rolesRepository = rolesRepository;
        }

        #region Roles
        public ServiceResult ListRol()
        {
            var result = new ServiceResult();
            try
            {
                var list = _rolesRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult FindRol(int Rol_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _rolesRepository.Find(Rol_Id);

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult CrearRol(tbRoles item)
        {
            var result = new ServiceResult();
            try
            {
                var reponse = _rolesRepository.Insert(item);
                if (reponse.CodeStatus == 1)
                {
                    return result.Ok("Rol creado con exito", reponse);
                }
                else
                {
                    return result.Error("Este rol ya existe");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult EditarRol(tbRoles item)
        {
            var result = new ServiceResult();
            try
            {
                var reponse = _rolesRepository.Update(item);
                if (reponse.CodeStatus == 1)
                {
                    return result.Ok($"Rol {item.Rol_Id} editado con éxito", reponse);
                }
                else
                {
                    return result.Error("Este rol ya existe");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult EliminarRol(int Rol_Id)
        {
            var result = new ServiceResult();
            try
            {
                var reponse = _rolesRepository.Delete(Rol_Id);
                if (reponse.CodeStatus == 1)
                {
                    return result.Ok($"Rol {Rol_Id} desactivado", reponse);
                }
                else
                {
                    return result.Error("No se encontró el rol a desactivar");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        #endregion

        #region Pantallas
        public ServiceResult ListPant()
        {
            var result = new ServiceResult();
            try
            {
                var list = _pantallasRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        #endregion

    }
}
