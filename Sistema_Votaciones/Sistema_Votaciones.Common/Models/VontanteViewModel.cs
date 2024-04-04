﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.Common.Models
{
  public  class VontanteViewModel
    {
        public int Vota_Id { get; set; }
        public string Vota_Nombre { get; set; }
        public string Vota_Apellidos { get; set; }
        public string Vota_DNI { get; set; }
        public bool Vota_YaVoto { get; set; }
        public string Muni_Codigo { get; set; }
        public int Esta_Id { get; set; }
        public int Vota_UsuarioCreacion { get; set; }
        public DateTime Vota_FechaCreacion { get; set; }
        public int? Vota_UsuarioModifica { get; set; }
        public DateTime? Vota_FechaModifica { get; set; }
        public int? MePS_Id { get; set; }
    }
}
