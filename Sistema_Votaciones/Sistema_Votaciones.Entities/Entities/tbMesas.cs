﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_Votaciones.Entities.Entities
{
    public partial class tbMesas
    {
        public int Mesa_Id { get; set; }
        public int Mesa_UsuarioCreacion { get; set; }
        public DateTime Mesa_FechaCreacion { get; set; }
        public int? Mesa_UsuarioModifica { get; set; }
        public DateTime? Mesa_FechaModifica { get; set; }
        public bool? Mesa_Estado { get; set; }
        public int Mesa_Numero { get; set; }

        public virtual tbUsuarios Mesa_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios Mesa_UsuarioModificaNavigation { get; set; }
    }
}