using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.Common.Models
{
    public class DepartamentoViewModel
    {
        public string Dept_Codigo { get; set; }

        public string Dept_Descripcion { get; set; }

        public int Dept_UsuarioCreacion { get; set; }
        public DateTime Dept_FechaCreacion { get; set; }
        public int? Dept_UsuarioModifica { get; set; }
        public DateTime? Dept_FechaModifica { get; set; }

    }    
}
