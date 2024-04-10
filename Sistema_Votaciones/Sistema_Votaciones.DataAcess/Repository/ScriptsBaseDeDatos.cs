using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.DataAcess.Repository
{
    public class ScriptsBaseDeDatos
    {
        #region Usuarios
        public static string Usua_Listar = "[Acce].[SP_Usuarios_Mostrar]";
        public static string Usua_Llenar = "[Acce].[SP_Usuarios_Llenar]";
        public static string Usua_LlenarByEmpl = "[Acce].[SP_Usuarios_LlenarByEmpl]";
        public static string Usua_Insertar = "[Acce].[SP_Usuarios_Insertar]";
        public static string Usua_Editar = "[Acce].[SP_Usuarios_Editar]";
        public static string Usua_ActivarDesactivar = "[Acce].[SP_Usuarios_ActivarDesactivar]";
        public static string Usua_IniciarSesion = "[Acce].[SP_Usuarios_IniciarSesion]";
        #endregion

        #region Roles
        public static string Rol_Listar = "[Acce].[SP_Roles_Mostrar]";
        public static string Rol_Llenar = "[Acce].[SP_Roles_Listar]";
        public static string Rol_Insertar = "[Acce].[SP_Roles_Insertar]";
        public static string Rol_Editar = "[Acce].[SP_Roles_Editar]";
        public static string Rol_Eliminar = "[Acce].[SP_Roles_Eliminar]";
        #endregion

        #region Pantallas
        public static string Pant_Listar = "[Acce].[SP_Pantallas_Mostrar]";
        #endregion
        
        #region PantallasPorRoles
        public static string Paro_Listar = "[Acce].[SP_PantallasPorRoles_Mostrar]";
        public static string Paro_Insertar = "[Acce].[SP_PantallasPorRoles_Insertar]";
        public static string Paro_Eliminar = "[Acce].[SP_PantallasPorRoles_Eliminar]";
        #endregion

        #region Departamentos
        public static string Depa_Listar = "[Gral].[SP_Departamentos_Mostrar]";
        public static string Depa_Llenar = "[Gral].[SP_Departamentos_Llenar]";
        public static string Depa_Insertar = "[Gral].[SP_Departamentos_Insertar]";
        public static string Depa_Editar = "[Gral].[SP_Departamentos_Editar]";
        public static string Depa_Eliminar = "[Gral].[SP_Departamentos_Eliminar]";
        #endregion
        
        #region Municipios
        public static string Muni_Listar = "[Gral].[SP_Municipios_Mostrar]";
        public static string Muni_ListarPorDept = "[Gral].[SP_Municipios_Listar]";
        public static string Muni_Llenar = "[Gral].[SP_Municipios_Llenar]";
        public static string Muni_Insertar = "[Gral].[SP_Municipios_Insertar]";
        public static string Muni_Editar = "[Gral].[SP_Municipios_Editar]";
        public static string Muni_Eliminar = "[Gral].[SP_Municipios_Eliminar]";
        #endregion

        #region Cargos
        public static string Carg_Listar = "[Gral].[SP_Cargos_Mostrar]";
        public static string Carg_ListarPorDept = "[Gral].[SP_Cargos_Listar]";
        public static string Carg_Llenar = "[Gral].[SP_Cargos_Llenar]";
        public static string Carg_Insertar = "[Gral].[SP_Cargos_Insertar]";
        public static string Carg_Editar = "[Gral].[SP_Cargos_Editar]";
        public static string Carg_Eliminar = "[Acce].[SP_Cargos_Eliminar]";
        #endregion

        #region EstadosCiviles
        public static string Esta_Listar = "[Gral].[SP_EstadosCiviles_Mostrar]";
        public static string Esta_Llenar = "[Gral].[SP_EstadosCiviles_Llenar]";
        public static string Esta_Insertar = "[Gral].[SP_EstadosCiviles_Insertar]";
        public static string Esta_Editar = "[Gral].[SP_EstadosCiviles_Editar]";
        public static string Esta_Eliminar = "[Acce].[SP_EstadosCiviles_Eliminar]";
        #endregion

        #region Empleados
        public static string Empl_Listar = "[Gral].[SP_Empleados_Mostrar]";
        public static string Empl_Llenar = "[Gral].[SP_Empleados_Llenar]";
        public static string Empl_Insertar = "[Gral].[SP_Empleados_Insertar]";
        public static string Empl_Editar = "[Gral].[SP_Empleados_Editar]";
        public static string Empl_ActivarDesactivar = "[Gral].[SP_Empleados_ActivarDesactivar]";
        #endregion

        #region Sedes
        public static string Sede_Listar = "[Gral].[SP_Sedes_Mostrar]";
        public static string Sede_Llenar = "[Gral].[SP_Sedes_Llenar]";
        public static string Sede_Insertar = "[Gral].[SP_Sedes_Insertar]";
        public static string Sede_Editar = "[Gral].[SP_Sedes_Editar]";
        public static string Sede_Eliminar = "[Acce].[SP_Sedes_Eliminar]";
        #endregion

        #region Mesas
        public static string Mesa_Listar = "[Gral].[SP_Mesas_Mostrar]";
        public static string Mesa_Llenar = "[Gral].[SP_Mesas_Llenar]";
        public static string Mesa_Insertar = "[Gral].[SP_Mesas_Insertar]";
        public static string Mesa_Editar = "[Gral].[SP_Mesas_Editar]";
        public static string Mesa_Eliminar = "[Acce].[SP_Mesas_Eliminar]";
        #endregion

        #region Alcaldes
        public static string Alca_Listar = "[Vota].[SP_Alcaldes_Mostrar]";
        public static string Alca_Llenar = "[Vota].[SP_Alcaldes_Listar]";
        public static string Alca_Insertar = "[Vota].[SP_Alca_Insertar]";
        public static string Alca_Editar = "[Vota].[SP_Alca_Editar]";
        public static string Alca_Eliminar = "[Vota].[SP_Alca_Eliminar]";
        #endregion

        #region Presidentes
        public static string Presi_Listar = "[Vota].[SP_Presidentes_Mostrar]";
        public static string Presi_Llenar = "[Vota].[SP_Presidentes_Listar]";
        public static string Presi_Insertar = "[Vota].[SP_Presidentes_Insertar]";
        public static string Presi_Editar = "[Vota].[SP_Presidentes_Editar]";
        public static string Presi_Eliminar = "[Vota].[SP_Presidentes_Eliminar]";
        #endregion

        #region Partidos
        public static string Part_Listar = "[Vota].[SP_Partidos_Mostrar]";
        public static string Part_Llenar = "[Vota].[SP_Partidos_Llenar]";
        public static string Part_Insertar = "[Vota].[SP_Partidos_Insertar]";
        public static string Part_Editar = "[Vota].[SP_Partidos_Editar]";
        public static string Part_Eliminar = "[Vota].[SP_Partidos_Eliminar]";
        #endregion
        
        #region VotosPorMesas
        public static string VotosPorMesas_Listar = "[Vota].[SP_VotosPorMesas_Mostrar]";
        public static string VotosPorMesas_Insertar = "[Vota].[SP_VotosPorMesas_Insertar]";
        public static string VotosPorMesas_Editar = "[Vota].[SP_VotosPorMesas_Editar]";
        public static string VotosPorMesas_Eliminar = "[Vota].[SP_VotosPorMesas_Eliminar]";
        public static string VotosPorMesas_ListarPresidentes = "[Vota].[SP_VotosPorMesas_MostrarPresidentes]";
        public static string VotosPorMesas_ListarAlcaldes = "[Vota].[SP_VotosPorMesas_MostrarAlcaldes]";
        public static string VotosPorMesas_ListarAlcaldesPorMunicipio = "[Vota].[SP_VotosPorMesas_MostrarAlcaldes_PorMunicipio]";

        public static string VotosPorMesas_MarcarVoto = "[Gral].[SP_MarcarVotanteComoYaVoto]";
        #endregion

        #region Votantes
        public static string Vota_Listar = "[Gral].[SP_Votantes_Mostrar]";
        public static string Vota_ListarPorDept = "[Gral].[SP_Votantes_Listar]";
        public static string Vota_Llenar = "[Gral].[SP_Votantes_Llenar]";
        public static string Vota_Insertar = "[Gral].[SP_Votantes_Insertar]";
        public static string Vota_Editar = "[Gral].[SP_Votantes_Editar]";
        public static string Vota_Eliminar = "[Gral].[SP_Votantes_Eliminar]";
        public static string Vota_ListarCandidatos = "[Gral].[SP_Votantes_MostrarCandidatos]";
        #endregion



    }
}
