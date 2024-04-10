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
        public bool? Empl_Estado { get; set; }
        [Display(Name = "Partido Id")]
        public int Part_Id { get; set; }
        [Display(Name = "Cargo Id")]
        public int Carg_Id { get; set; }
        [Display(Name = "Empleado Id")]
        public int Empl_Id { get; set; }
        [Display(Name = "Departamento Codigo")]
        public string Dept_Codigo { get; set; }
        [Display(Name = "Sede Id")]
        public int Sede_Id { get; set; }
        [Display(Name = "Mesa Id")]
        public int Mesa_Id { get; set; }
    }
}
