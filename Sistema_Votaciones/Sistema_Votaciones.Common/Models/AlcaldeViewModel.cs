using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.Common.Models
{
   public class AlcaldeViewModel
    {
        public string Vota_NombreCompleto { get; set; }
        public string Vota_DNI { get; set; }
        public string Alca_Imagen { get; set; }
        public string Muni_Codigo { get; set; }
        public string Dept_Codigo { get; set; }
        public string Muni_Descripcion { get; set; }
        public int Part_Id { get; set; }
        public string Part_Descripcion { get; set; }
        public int Alca_Id { get; set; }
        public int Alca_UsuarioCreacion { get; set; }
        public DateTime Alca_FechaCreacion { get; set; }
        public int? Alca_UsuarioModifica { get; set; }
        public DateTime? Alca_FechaModifica { get; set; }
    }
}
