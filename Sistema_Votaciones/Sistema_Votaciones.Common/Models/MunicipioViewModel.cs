using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.Common.Models
{
    public class MunicipioViewModel
    {
        public string Muni_Codigo { get; set; }
        public string Muni_Descripcion { get; set; }
        public string Dept_Codigo { get; set; }
        public string Dept_Descripcion { get; set; }

        public int Muni_UsuarioCreacion { get; set; }
        public DateTime Muni_FechaCreacion { get; set; }
        public int? Muni_UsuarioModifica { get; set; }
        public DateTime? Muni_FechaModifica { get; set; }
    }
}
