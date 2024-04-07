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
    }
}
