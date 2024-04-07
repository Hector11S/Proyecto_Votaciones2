using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class DepartamentoViewModel
    {
        [Display(Name = "Codigo")]
        public string Dept_Codigo { get; set; }
        [Display(Name = "Nombre")]
        public string Dept_Descripcion { get; set; }
        [Display(Name = "Usuario creacion")]
        public int Dept_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha creacion")]
        public DateTime Dept_FechaCreacion { get; set; }
        [Display(Name = "Usuario modifica")]
        public int? Dept_UsuarioModifica { get; set; }
        [Display(Name = "Fecha modifica")]
        public DateTime? Dept_FechaModifica { get; set; }
    }    
}