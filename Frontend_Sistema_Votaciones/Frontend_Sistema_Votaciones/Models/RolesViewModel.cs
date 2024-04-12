using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class RolesViewModel
    {
        [Display(Name = "Id")]
        public int Rol_Id { get; set; }
        [Display(Name = "Rol")]
        public string Rol_Descripcion { get; set; }
        public int Rol_UsuarioCreacion { get; set; }
        public DateTime Rol_FechaCreacion { get; set; }
        public int? Rol_UsuarioModifica { get; set; }
        public DateTime? Rol_FechaModifica { get; set; }
        public bool? Rol_Estado { get; set; }
    }
}
