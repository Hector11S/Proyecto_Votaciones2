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

        [Display(Name = "Cargo Id")]
        public int Carg_Id { get; set; }

        [Display(Name = "Cargo")]
        public string Carg_Descripcion { get; set; }
        [Display(Name = "Usurio Creacion")]
        public int Carg_UsuarioCreacion { get; set; }
        [Display(Name = "Feacha Creacion")]
        public DateTime Carg_FechaCreacion { get; set; }
        [Display(Name = "Usuario Modifica")]
        public int? Carg_UsuarioModifica { get; set; }
        [Display(Name = "Fecha Modifica")]
        public DateTime? Carg_FechaModifica { get; set; }
        [Display(Name = "Estado")]
        public bool? Carg_Estado { get; set; }
    }
}
