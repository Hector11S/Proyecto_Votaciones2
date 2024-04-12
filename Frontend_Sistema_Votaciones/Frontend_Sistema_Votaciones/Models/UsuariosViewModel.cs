using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class UsuariosViewModel
    {
        [Display(Name = "Id")]
        public int Usua_Id { get; set; }
        [Display(Name = "Usuario")]

        public string Usua_Usuario { get; set; }
        [Display(Name = "Empleado DNI")]
        public string Vota_DNI { get; set; }

        [Display(Name = "Nombre Completo")]
        public string Vota_NombreCompleto { get; set; }
        [Display(Name = "Contraseña")]
        public string Usua_Contra { get; set; }
        [Display(Name = "Confirmar contraseña")]
        public string Usua_ContraConfirmar { get; set; }
        [Display(Name = "Administrador")]
        public bool Usua_Admin { get; set; }
        public int Empl_Id { get; set; }
        public int Rol_Id { get; set; }
        public int Usua_UsuarioCreacion { get; set; }
        public DateTime Usua_FechaCreacion { get; set; }
        public int? Usua_UsuarioModifica { get; set; }
        public DateTime? Usua_FechaModifica { get; set; }
        [Display(Name = "Estado")]
        public bool? Usua_Activo { get; set; }
        [Display(Name = "Imagen")]
        public string Usua_Imagen { get; set; }
        public string Muni_Codigo { get; set; }

    }
}
