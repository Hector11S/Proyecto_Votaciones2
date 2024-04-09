using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class CargoViewModel
    {
        [Display(Name = "Id")]

        public int Carg_Id { get; set; }
        [Display(Name = "Cargo")]
        public string Carg_Descripcion { get; set; }
        public int Carg_UsuarioCreacion { get; set; }
        public DateTime Carg_FechaCreacion { get; set; }
        public int? Carg_UsuarioModifica { get; set; }
        public DateTime? Carg_FechaModifica { get; set; }
        public bool? Carg_Estado { get; set; }
    }
}
