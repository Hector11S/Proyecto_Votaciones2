using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class VotosPorMesasViewModel
    {
        [Display(Name = "Votos Por Mesas Id")]
        public int VoMe_Id { get; set; }

        [Display(Name = "Mesas Por Sedes")]
        public int MePS_Id { get; set; }

        [Display(Name = "Candidato")]
        public int VoMe_CandidatoId { get; set; }

        [Display(Name = "Es Presidente")]
        public bool VoMe_EsPresidente { get; set; }

        [Display(Name = "Cargo")]
        public string Cargo { get; set; }

        [Display(Name = "Candidato")]
        public int CandidatoId { get; set; }

        [Display(Name = "Total Votos")]
        public int TotalVotos { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }


        [Display(Name = "Nombre del Presidente")]
        public string NombrePresidente { get; set; }

        [Display(Name = "Apellido del Presidente")]
        public string ApellidoPresidente { get; set; }

        [Display(Name = "Cargo del Presidente")]
        public string CargoPresidente { get; set; }

        [Display(Name = "ID del Candidato Presidente")]
        public int CandidatoIdPresidente { get; set; }

        [Display(Name = "Total de Votos para el Presidente")]
        public int TotalVotosPresidentes { get; set; }

        [Display(Name = "Nombre del Alcalde")]
        public string NombreAlcalde { get; set; }

        [Display(Name = "Apellido del Alcalde")]
        public string ApellidoAlcalde { get; set; }

        [Display(Name = "Cargo del Alcalde")]
        public string CargoAlcalde { get; set; }

        [Display(Name = "ID del Candidato Alcalde")]
        public int CandidatoIdAlcalde { get; set; }

        [Display(Name = "Total de Votos para el Alcalde")]
        public int TotalVotosAlcalde { get; set; }

        public bool Vota_YaVoto { get; set; }

        public string Muni_Codigo { get; set; }
        public string Muni_Descripcion { get; set; }
        public string Dept_Codigo { get; set; }
    }
}
