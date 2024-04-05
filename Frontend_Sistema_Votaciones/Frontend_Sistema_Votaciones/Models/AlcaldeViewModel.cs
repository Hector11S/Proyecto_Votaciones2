using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class AlcaldeViewModel
    {
        [Display(Name = "Id")]
        public int Alca_Id { get; set; }
        [Display(Name = "Url imagen")]
        public string Alca_Imagen { get; set; }
        [Display(Name = "Municipio codigo")]
        public string Muni_Codigo { get; set; }
        [Display(Name = "Id Partido")]
        public int Part_Id { get; set; }

        [Display(Name = "Usuario creacion")]
        public int Alca_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha creacion")]
        public DateTime Alca_FechaCreacion { get; set; }
        [Display(Name = "Usuario modifica")]
        public int? Alca_UsuarioModifica { get; set; }
        [Display(Name = "Fecha modifica")]
        public DateTime? Alca_FechaModifica { get; set; }

        [Display(Name = "Nombre")]
        [NotMapped]
        public string Vota_Nombre { get; internal set; }
    }
}
