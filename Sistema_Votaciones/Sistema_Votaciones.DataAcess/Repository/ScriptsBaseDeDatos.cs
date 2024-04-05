﻿using System;
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

        #region Alcaldes
        public static string Alca_Listar = "[Vota].[SP_Alcaldes_Mostrar]";
        public static string Alca_Insertar = "[Vota].[SP_Alca_Insertar]";
        public static string Alca_Editar = "[Vota].[SP_Alca_Editar]";
        public static string Alca_Eliminar = "[Vota].[SP_Alca_Eliminar]";
        #endregion

        #region Partidos
        public static string Part_Listar = "[Vota].[SP_Partidos_Mostrar]";
        public static string Part_Insertar = "[Vota].[SP_Partidos_Insertar]";
        public static string Part_Editar = "[Vota].[SP_Partidos_Editar]";
        public static string Part_Eliminar = "[Vota].[SP_Partidos_Eliminar]";
        #endregion

        #region VotosPorMesas
        public static string VotosPorMesas_Listar = "[Vota].[SP_VotosPorMesas_Mostrar]";
        public static string VotosPorMesas_Insertar = "[Vota].[SP_VotosPorMesas_Insertar]";
        public static string VotosPorMesas_Editar = "[Vota].[SP_VotosPorMesas_Editar]";
        public static string VotosPorMesas_Eliminar = "[Vota].[SP_VotosPorMesas_Eliminar]";
        #endregion

        #region Votantes
        public static string Vota_Llenar = "[Gral].[SP_Votantes_Llenar]";
        #endregion
    }
}
