using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.Common.Models
{
    public class PartidoViewModel
    {
        public int Part_Id { get; set; }
        public string Part_Descripcion { get; set; }
        public int Part_UsuarioCreacion { get; set; }
        public DateTime Part_FechaCreacion { get; set; }
        public int? Part_UsuarioModifica { get; set; }
        public DateTime? Part_FechaModifica { get; set; }
        public bool? Part_Estado { get; set; }
        public string Part_Imagen { get; set; }
    }
}
