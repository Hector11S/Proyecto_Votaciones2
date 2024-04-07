using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.Common.Models
{
    public class EstadosCivilesViewModel
    {
        public int Esta_Id { get; set; }
        public string Esta_Descripcion { get; set; }
        public int Esta_UsuarioCreacion { get; set; }
        public DateTime Esta_FechaCreacion { get; set; }
        public int? Esta_UsuarioModifica { get; set; }
        public DateTime? Esta_FechaModifica { get; set; }
    }
}
