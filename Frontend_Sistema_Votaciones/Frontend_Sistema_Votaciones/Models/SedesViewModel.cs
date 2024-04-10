using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class SedesViewModel
    {
        public int Sede_Id { get; set; }
        public string Sede_Descripcion { get; set; }

        [Display(Name = "Codigo")]
        public string Muni_Codigo { get; set; }
        [Display(Name = "Nombre")]
        public string Muni_Descripcion { get; set; }
        [Display(Name = "Codigo Departamento")]
        public string Dept_Codigo { get; set; }
        [Display(Name = "Usuario Creacion")]
        public int Sede_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime Sede_FechaCreacion { get; set; }
        [Display(Name = "Usuario Modificacion")]
        public int? Sede_UsuarioModifica { get; set; }
        [Display(Name = "Fecha Modificacion")]
        public DateTime? Sede_FechaModifica { get; set; }
        [Display(Name = "Estado")]
        public bool? Sede_Estado { get; set; }
    }
}
