using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.DataAcess.Repository
{
    public class ScriptsBaseDeDatos
    {
        #region Departamentos
        public static string Depa_Listar = "[Gral].[SP_Departamentos_Mostrar]";
        public static string Depa_Insertar = "[Gral].[SP_Departamentos_Insertar]";
        public static string Depa_Editar = "[Gral].[SP_Departamentos_Editar]";
        public static string Depa_Eliminar = "[Gral].[SP_Departamentos_Eliminar]";
        #endregion


        #region Alcaldes
        public static string Alca_Listar = "[Vota].[SP_Alcaldes_Mostrar]";
        public static string Alca_Insertar = "[Vota].[SP_Alca_Insertar]";
        public static string Alca_Editar = "[Vota].[SP_Alca_Editar]";
        public static string Alca_Eliminar = "[Vota].[SP_Alca_Eliminar]";
        #endregion

        #region VotosPorMesas
        public static string VotosPorMesas_Listar = "[Vota].[SP_VotosPorMesas_Mostrar]";
        public static string VotosPorMesas_Insertar = "[Vota].[SP_VotosPorMesas_Insertar]";
        public static string VotosPorMesas_Editar = "[Vota].[SP_VotosPorMesas_Editar]";
        public static string VotosPorMesas_Eliminar = "[Vota].[SP_VotosPorMesas_Eliminar]";
        #endregion

        #region Votantes
        public static string Votantes_Listar = "[Gral].[SP_Votantes_Mostrar]";
        public static string Votantes_Insertar = "[Gral].[SP_Votantes_Insertar]";
        public static string Votantes_Editar = "[Gral].[SP_Votantes_Editar]";
        public static string Votantes_Eliminar = "[Gral].[SP_Votantes_Eliminar]";
        public static string Votante_BuscarPorDNI = "[Gral].[SP_Votantes_BuscarPorDNI]";
        #endregion
    }
}
