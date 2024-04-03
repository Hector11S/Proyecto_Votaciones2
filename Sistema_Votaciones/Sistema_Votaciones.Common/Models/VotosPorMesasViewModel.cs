using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.Common.Models
{
    public class VotosPorMesasViewModel
    {
        public int VoMe_Id { get; set; }
        public int MePS_Id { get; set; }
        public int VoMe_CandidatoId { get; set; }
        public bool VoMe_EsPresidente { get; set; }
    }
}
