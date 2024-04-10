using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.Common.Models
{
    public class PresidenteViewModel
    {
        public int Pres_Id { get; set; }
        public string Pres_Imagen { get; set; }
        public int Part_Id { get; set; }
        public string Part_Descripcion { get; set; }
        public int Pres_UsuarioCreacion { get; set; }
        public DateTime Pres_FechaCreacion { get; set; }
        public int? Pres_UsuarioModifica { get; set; }
        public DateTime? Pres_FechaModifica { get; set; }
        public bool? Pres_Estado { get; set; }
        public string Vota_NombreCompleto { get; set; }

        public string Muni_Codigo { get; set; }
        public string Dept_Codigo { get; set; }
        public string Muni_Descripcion { get; set; }
    }
}
