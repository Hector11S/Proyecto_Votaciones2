﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_Votaciones.Entities.Entities
{
    public partial class tbPresidentes
    {
        public string Part_Descripcion { get; set; }
        public int Pres_Id { get; set; }
        public string Pres_Imagen { get; set; }
        public int Part_Id { get; set; }
        public string Muni_Codigo { get; set; }
        public string Dept_Codigo { get; set; }
        public string Muni_Descripcion { get; set; }
        public int Pres_UsuarioCreacion { get; set; }
        public DateTime Pres_FechaCreacion { get; set; }
        public int? Pres_UsuarioModifica { get; set; }
        public DateTime? Pres_FechaModifica { get; set; }
        public bool? Pres_Estado { get; set; }
        public string Vota_NombreCompleto { get; set; }
        public virtual tbPartidos Part { get; set; }
        public virtual tbVotantes Pres { get; set; }
        public virtual tbUsuarios Pres_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios Pres_UsuarioModificaNavigation { get; set; }
    }
}