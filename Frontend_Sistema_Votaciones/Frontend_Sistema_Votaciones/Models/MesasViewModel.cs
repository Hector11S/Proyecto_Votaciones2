using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class MesasViewModel
    {
        [Display(Name = "Mesa Id")]
        public int Mesa_Id { get; set; }
        [Display(Name = "Usuario Crecaion")]
        public int Mesa_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime Mesa_FechaCreacion { get; set; }
        [Display(Name = "Usuario Modifica")]
        public int? Mesa_UsuarioModifica { get; set; }
        [Display(Name = "Fecha Modifica")]
        public DateTime? Mesa_FechaModifica { get; set; }
        [Display(Name = "Estado")]
        public bool? Mesa_Estado { get; set; }
        [Display(Name = "Numero de Mesa")]
        public int Mesa_Numero { get; set; }
    }
}
