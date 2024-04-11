﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.Common.Models
{
    public class EmpleadosViewModel
    {
        public int Empl_UsuarioCreacion { get; set; }
        public DateTime Empl_FechaCreacion { get; set; }
        public int? Empl_UsuarioModifica { get; set; }
        public DateTime? Empl_FechaModifica { get; set; }
        public bool? Empl_Estado { get; set; }
        public int Part_Id { get; set; }
        public int Carg_Id { get; set; }
        public int Empl_Id { get; set; }
        public string Dept_Codigo { get; set; }
        public int Sede_Id { get; set; }
        public int Mesa_Id { get; set; }

        public string Muni_Codigo { get; set; }
        public string Muni_Descripcion { get; set; }

        public string Part_Descripcion { get; set; }
        public string Carg_Descripcion { get; set; }
        public int Mesa_Numero { get; set; }
        public string Sede_Descripcion { get; set; }
        public string Vota_DNI { get; set; }
        public int MePS_Id { get; set; }

        public string Vota_NombreCompleto { get; set; }
    }
}
