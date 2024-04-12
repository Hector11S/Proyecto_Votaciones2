using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    class MesasPorSedesViewModel
    {

        public int MePS_Id { get; set; }
        public int Mesa_Id { get; set; }
        public string Mesa_Numero { get; set; }
        public int Sede_Id { get; set; }
        public string Sede_Descripcion { get; set; }

        [Display(Name = "Codigo")]
        public string Muni_Codigo { get; set; }
        [Display(Name = "Nombre")]
        public string Muni_Descripcion { get; set; }
        [Display(Name = "Codigo Departamento")]
        public string Dept_Codigo { get; set; }
    }
}
