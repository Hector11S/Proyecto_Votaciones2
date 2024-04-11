using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class PantallasViewModel
    {
        public int Pant_Id { get; set; }
        public string Pant_Descripcion { get; set; }
        public int Pant_UsuarioCreacion { get; set; }
        public DateTime Pant_FechaCreacion { get; set; }
        public int? Pant_UsuarioModifica { get; set; }
        public DateTime? Pant_FechaModifica { get; set; }
        public bool? Pant_Estado { get; set; }
        public string Pant_Esquema { get; set; }
        public string Pant_Controlador { get; set; }
        public int Esqu_Id { get; set; }
        public string Esqu_Descripcion { get; set; }
        public string Pant_IconoBootstrap { get; set; }

    }
}
