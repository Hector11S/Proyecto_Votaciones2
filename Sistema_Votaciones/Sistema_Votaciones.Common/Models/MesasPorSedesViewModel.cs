using Sistema_Votaciones.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.Common.Models
{
    class MesasPorSedesViewModel
    {
        public MesasPorSedesViewModel()
        {
            tbVotantes = new HashSet<tbVotantes>();
        }

        public int MePS_Id { get; set; }
        public int Mesa_Id { get; set; }
        public int Sede_Id { get; set; }

        public virtual ICollection<tbVotantes> tbVotantes { get; set; }
    }
}
