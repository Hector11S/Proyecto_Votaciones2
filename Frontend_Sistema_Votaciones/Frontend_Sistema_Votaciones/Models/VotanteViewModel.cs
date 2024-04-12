using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class VotanteViewModel
    {
        [Display(Name = "Votante Id")]
        public int Vota_Id { get; set; }
        [Display(Name = "Nombre")]
        public string Vota_Nombre { get; set; }
        [Display(Name = "Apellido")]
        public string Vota_Apellidos { get; set; }
        [Display(Name = "DNI")]
        public string Vota_DNI { get; set; }
        [Display(Name = "Ya Voto")]
        public bool Vota_YaVoto { get; set; }
        [Display(Name = "Codigo Municipio")]
        public string Muni_Codigo { get; set; }
        [Display(Name = "Estado Civil Id")]
        public int Esta_Id { get; set; }
        [Display(Name = "Usuario Creacion")]
        public int Vota_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime Vota_FechaCreacion { get; set; }
        [Display(Name = "Usuario Modifica")]
        public int? Vota_UsuarioModifica { get; set; }
        [Display(Name = "Fecha Modifica")]
        public DateTime? Vota_FechaModifica { get; set; }
        [Display(Name = "Mesas Por Sedes")]
        public int? MePS_Id { get; set; }
        [Display(Name = "Voto Permitido")]
        public bool Vota_Permitido { get; set; }

        [Display(Name = "Municipio")]
        public string Muni_Descripcion { get; set; }

        [Display(Name = "Estado Civil")]
        public string Esta_Descripcion { get; set; }

        public int Sede_Id { get; set; }
        [Display(Name = "Numero de Mesa")]
        public int Mesa_Numero { get; set; }

        [Display(Name = "Sede")]
        public string Sede_Descripcion { get; set; }
        public int Mesa_Id { get; set; }
        public string Dept_Codigo { get; set; }
    }
}
