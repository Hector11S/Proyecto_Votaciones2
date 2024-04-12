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
                return result.Error("Error al crear el rol");
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

        #region Usuarios
        public ServiceResult ListUsua()
        {
            var result = new ServiceResult();
            try
            {
                var list = _usuariosRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult IniciarSesion(tbUsuarios item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _usuariosRepository.Find(item);

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Usuario o contraseña incorrectos");
            }
        }
        public ServiceResult FindUsua(int Usua_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _usuariosRepository.Find(Usua_Id);

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult FindUsuaByEmpl(int Empl_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _usuariosRepository.FindByEmpl(Empl_Id);

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult CrearUsua(tbUsuarios item)
        {
            var result = new ServiceResult();
            try
            {
                var reponse = _usuariosRepository.Insert(item);
                if (reponse.CodeStatus == 1)
                {
                    return result.Ok("Usuario creado con exito", reponse);
                }
                else
                {
                    return result.Error("Ya hay alguien más que utiliza este nombre de usuario");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al crear el usuario");
            }
        }
        public ServiceResult EditarUsua(tbUsuarios item)
        {
            var result = new ServiceResult();
            try
            {
                var reponse = _usuariosRepository.Update(item);
                if (reponse.CodeStatus == 1)
                {
                    return result.Ok($"Usuario {item.Usua_Id} editado con éxito", reponse);
                }
                else
                {
                    return result.Error("Por favor rellene todos los campos");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult ActivarDesactivarUsua(int Usua_Id)
        {
            var result = new ServiceResult();
            try
            {
                var reponse = _usuariosRepository.Update(Usua_Id);
                if (reponse.CodeStatus == 1)
                {
                    return result.Ok($"Usuario {Usua_Id} actualizado", reponse);
                }
                else
                {
                    return result.Error("Error al actualizar el usuario");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al actualizar el usuario");
            }
        }
        #endregion

        #region PantallasPorRoles
        public ServiceResult ListParo()
        {
            var result = new ServiceResult();
            try
            {
                var list = _pantallasPorRolesRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult FindParo(int Paro_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _pantallasPorRolesRepository.Find(Paro_Id);

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult CrearParo(tbPantallasPorRoles item)
        {
            var result = new ServiceResult();
            try
            {
                var reponse = _pantallasPorRolesRepository.Insert(item);
                if (reponse.CodeStatus == 1)
                {
                    return result.Ok("Pantalla vinculada con exito", reponse);
                }
                else
                {
                    return result.Error("Error al vincular la pantalla al rol");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al vincular la pantalla al rol");
            }
        }
        
        public ServiceResult EliminarParo(int Rol_Id, int Pant_Id)
        {
            var result = new ServiceResult();
            try
            {
                var reponse = _pantallasPorRolesRepository.Delete(Rol_Id, Pant_Id);
                if (reponse.CodeStatus == 1)
                {
                    return result.Ok($"Pantalla desactivada", reponse);
                }
                else
                {
                    return result.Error("Error al desactivar la pantalla");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error al desactivar la pantalla");
            }
        }
        #endregion
    }
}
