using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class PresidenteViewModel
    {
        [Display(Name = "Presidente Id")]
        public int Pres_Id { get; set; }

        [Display(Name = "DNI")]
        public string Vota_DNI { get; set; }

        [Display(Name = "Presidente Imagen")]
        public string Pres_Imagen { get; set; }

        [Display(Name = "Partido ID")]
        public int Part_Id { get; set; }

        [Display(Name = "Partido")]
        public string Part_Descripcion { get; set; }

        [Display(Name = "Usuario creacion")]
        public int Pres_UsuarioCreacion { get; set; }

        [Display(Name = "Fecha creacion")]
        public DateTime Pres_FechaCreacion { get; set; }

        [Display(Name = "Usuario Modifica")]
        public int? Pres_UsuarioModifica { get; set; }

        [Display(Name = "Fecha Modifica")]
        public DateTime? Pres_FechaModifica { get; set; }

        [Display(Name = "Estado")]
        public bool? Pres_Estado { get; set; }

        [Display(Name = "Nombre Completo")]
        public string Vota_NombreCompleto { get; set; }

        public string Muni_Codigo { get; set; }
        public string Dept_Codigo { get; set; }
        public string Muni_Descripcion { get; set; }

    }
}
