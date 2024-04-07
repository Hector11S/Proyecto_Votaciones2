using Sistema_Votaciones.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.Common.Models
{
    public class CargoViewModel
    {
        public CargoViewModel()
        {
            tbEmpleados = new HashSet<tbEmpleados>();
        }

        public int Carg_Id { get; set; }
        public string Carg_Descripcion { get; set; }
        public int Carg_UsuarioCreacion { get; set; }
        public DateTime Carg_FechaCreacion { get; set; }
        public int? Carg_UsuarioModifica { get; set; }
        public DateTime? Carg_FechaModifica { get; set; }
        public bool? Carg_Estado { get; set; }

        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
    }
}
