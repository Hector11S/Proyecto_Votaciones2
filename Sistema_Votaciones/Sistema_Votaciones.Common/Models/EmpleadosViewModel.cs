using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.Common.Models
{
    public class EmpleadosViewModel
    {
        public int Empl_UsuarioCreacion { get; set; }
        public DateTime Empl_FechaCreacion { get; set; }
        public int? Empl_UsuarioModifica { get; set; }
        public DateTime? Empl_FechaModifica { get; set; }
        public bool? Empl_Estado { get; set; }
        public int Part_Id { get; set; }
        public int Carg_Id { get; set; }
        public int Empl_Id { get; set; }
        public int Sede_Id { get; set; }
        public int Mesa_Id { get; set; }
    }
}
