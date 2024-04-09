﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_Votaciones.Entities.Entities
{
    public partial class tbPartidos
    {
        public tbPartidos()
        {
            tbAlcaldes = new HashSet<tbAlcaldes>();
            tbEmpleados = new HashSet<tbEmpleados>();
            tbPresidentes = new HashSet<tbPresidentes>();
        }

        public int Part_Id { get; set; }
        public string Part_Descripcion { get; set; }
        public int Part_UsuarioCreacion { get; set; }
        public DateTime Part_FechaCreacion { get; set; }
        public int? Part_UsuarioModifica { get; set; }
        public DateTime? Part_FechaModifica { get; set; }
        public bool? Part_Estado { get; set; }
        public string Part_Imagen { get; set; }
        public string Part_Color { get; set; }

        public virtual tbUsuarios Part_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios Part_UsuarioModificaNavigation { get; set; }
        public virtual ICollection<tbAlcaldes> tbAlcaldes { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
        public virtual ICollection<tbPresidentes> tbPresidentes { get; set; }
    }
}