using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.Common.Models
{
    public class PantallasPorRolesViewModel
    {
        public int Paro_Id { get; set; }
        public int Rol_Id { get; set; }
        public int Pant_Id { get; set; }
        public string Pant_Descripcion { get; set; }
        public string Pant_Controlador { get; set; }
        public string Pant_IconoBootstrap { get; set; }

        public int Esqu_Id { get; set; }
        public string Esqu_Descripcion { get; set; }
    }
}
