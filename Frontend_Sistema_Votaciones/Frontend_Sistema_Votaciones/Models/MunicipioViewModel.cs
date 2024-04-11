using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class MunicipioViewModel
    {
        [Display(Name = "Codigo")]
        public string Muni_Codigo { get; set; }
        [Display(Name = "Municipio")]
        public string Muni_Descripcion { get; set; }
        [Display(Name = "Codigo Departamento")]
        public string Dept_Codigo { get; set; }
        [Display(Name = "Departamento")]
        public string Dept_Descripcion { get; set; }

        [Display(Name = "Usuario creacion")]
        public int Muni_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha creacion")]
        public DateTime Muni_FechaCreacion { get; set; }
        [Display(Name = "Usuario modifica")]
        public int? Muni_UsuarioModifica { get; set; }
        [Display(Name = "Fecha modifica")]
        public DateTime? Muni_FechaModifica { get; set; }
    }
}
