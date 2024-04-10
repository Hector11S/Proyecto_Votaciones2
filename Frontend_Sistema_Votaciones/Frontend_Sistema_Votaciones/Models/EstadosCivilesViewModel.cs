using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class EstadosCivilesViewModel
    {

        [Display(Name = "Estado civil Id")]
        public int Esta_Id { get; set; }

        [Display(Name = "Estado Civil")]
        public string Esta_Descripcion { get; set; }

        [Display(Name = "Usuario Creacion")]
        public int Esta_UsuarioCreacion { get; set; }

        [Display(Name = "Fecha Creacion")]
        public DateTime Esta_FechaCreacion { get; set; }

        [Display(Name = "Usuario Modifica")]
        public int? Esta_UsuarioModifica { get; set; }

        [Display(Name = "Fecha Modifica")]
        public DateTime? Esta_FechaModifica { get; set; }
    }
}
