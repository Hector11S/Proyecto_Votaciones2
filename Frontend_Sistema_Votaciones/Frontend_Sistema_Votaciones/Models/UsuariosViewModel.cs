using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class UsuariosViewModel
    {
        public int Usua_Id { get; set; }
        public string Usua_Usuario { get; set; }
        public string Usua_Contra { get; set; }
        public bool Usua_Admin { get; set; }
        public int Empl_Id { get; set; }
        public int Rol_Id { get; set; }
        public int Usua_UsuarioCreacion { get; set; }
        public DateTime Usua_FechaCreacion { get; set; }
        public int? Usua_UsuarioModifica { get; set; }
        public DateTime? Usua_FechaModifica { get; set; }
        public bool? Usua_Activo { get; set; }
    }
}
