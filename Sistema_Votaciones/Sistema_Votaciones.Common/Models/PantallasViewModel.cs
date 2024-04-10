using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.Common.Models
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

    }
}
