using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.Common.Models
{
    public class SedesViewModel
    {
        public int Sede_Id { get; set; }
        public string Sede_Descripcion { get; set; }
        public string Muni_Codigo { get; set; }
        public string Muni_Descripcion { get; set; }
        public string Dept_Codigo { get; set; }
        public int Sede_UsuarioCreacion { get; set; }
        public DateTime Sede_FechaCreacion { get; set; }
        public int? Sede_UsuarioModifica { get; set; }
        public DateTime? Sede_FechaModifica { get; set; }
        public bool? Sede_Estado { get; set; }
    }
}
