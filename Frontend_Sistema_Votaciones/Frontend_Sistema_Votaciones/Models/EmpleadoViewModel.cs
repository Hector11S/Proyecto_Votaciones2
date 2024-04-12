using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class EmpleadoViewModel
    {
        [Display(Name = "Usuario Creacion")]
        public int Empl_UsuarioCreacion { get; set; }

        [Display(Name = "Fecha Creacion")]
        public DateTime Empl_FechaCreacion { get; set; }
        [Display(Name = "Usuario Modifica")]
        public int? Empl_UsuarioModifica { get; set; }
        [Display(Name = "Fecha Modifica")]
        public DateTime? Empl_FechaModifica { get; set; }
        [Display(Name = "Estado")]
        public bool Empl_Estado { get; set; }
        [Display(Name = "Partido ID")]
        public int Part_Id { get; set; }
        [Display(Name = "Cargo ID")]
        public int Carg_Id { get; set; }
        [Display(Name = "Empleado ID")]
        public int Empl_Id { get; set; }

        public string Dept_Codigo { get; set; }
        [Display(Name = "Sede ID")]
        public int Sede_Id { get; set; }
        [Display(Name = "Mesa ID")]
        public int Mesa_Id { get; set; }

        [Display(Name = "Partido")]
        public string Part_Descripcion { get; set; }
        [Display(Name = "Cargo")]
        public string Carg_Descripcion { get; set; }
        [Display(Name = "Numero de Mesa")]
        public int Mesa_Numero { get; set; }
        [Display(Name = "Sede")]
        public string Sede_Descripcion { get; set; }
        [Display(Name = "Mesa Por Sede ID")]
        public int MePS_Id { get; set; }

        [Display(Name = "Nombre Completo")]
        public string Vota_NombreCompleto { get; set; }
        public string Vota_DNI { get; set; }

        public string Muni_Codigo { get; set; }
        public string Muni_Descripcion { get; set; }

    }
}
