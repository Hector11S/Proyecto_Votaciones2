using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class PartidoViewModel
    {
        [Display(Name = "Id")]

        public int Part_Id { get; set; }
        [Display(Name = "Partido")]

        public string Part_Descripcion { get; set; }
        public int Part_UsuarioCreacion { get; set; }
        public DateTime Part_FechaCreacion { get; set; }
        public int? Part_UsuarioModifica { get; set; }
        public DateTime? Part_FechaModifica { get; set; }
        [Display(Name = "Estado")]

        public bool? Part_Estado { get; set; }
        [Display(Name = "Imagen")]

        public string Part_Imagen { get; set; }
        [Display(Name = "Color")]

        public string Part_Color { get; set; }

    }
}
