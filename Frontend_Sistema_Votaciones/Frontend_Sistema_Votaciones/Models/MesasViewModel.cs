using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.Common.Models
{
    public class MesasViewModel
    {
        public int Mesa_Id { get; set; }
        public int Mesa_UsuarioCreacion { get; set; }
        public DateTime Mesa_FechaCreacion { get; set; }
        public int? Mesa_UsuarioModifica { get; set; }
        public DateTime? Mesa_FechaModifica { get; set; }
        public bool? Mesa_Estado { get; set; }
        public int Mesa_Numero { get; set; }
    }
}
