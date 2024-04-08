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
        [Display(Name = "Id")]
        public int Mesa_Id { get; set; }
        public int Mesa_UsuarioCreacion { get; set; }
        public DateTime Mesa_FechaCreacion { get; set; }
        public int? Mesa_UsuarioModifica { get; set; }
        public DateTime? Mesa_FechaModifica { get; set; }
        public bool? Mesa_Estado { get; set; }
        [Display(Name="Numero de mesa")]
        public int Mesa_Numero { get; set; }
    }
}
