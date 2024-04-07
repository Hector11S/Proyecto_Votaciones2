using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.Common.Models
{
    public class RolesViewModel
    {
        public int Rol_Id { get; set; }
        public string Rol_Descripcion { get; set; }
        public int Rol_UsuarioCreacion { get; set; }
        public DateTime Rol_FechaCreacion { get; set; }
        public int? Rol_UsuarioModifica { get; set; }
        public DateTime? Rol_FechaModifica { get; set; }
        public bool? Rol_Estado { get; set; }
    }
}
