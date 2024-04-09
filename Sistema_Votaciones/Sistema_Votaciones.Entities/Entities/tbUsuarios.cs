﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_Votaciones.Entities.Entities
{
    public partial class tbUsuarios
    {
        public tbUsuarios()
        {
            InverseUsua_UsuarioCreacionNavigation = new HashSet<tbUsuarios>();
            InverseUsua_UsuarioModificaNavigation = new HashSet<tbUsuarios>();
            tbAlcaldesAlca_UsuarioCreacionNavigation = new HashSet<tbAlcaldes>();
            tbAlcaldesAlca_UsuarioModificaNavigation = new HashSet<tbAlcaldes>();
            tbCargosCarg_UsuarioCreacionNavigation = new HashSet<tbCargos>();
            tbCargosCarg_UsuarioModificaNavigation = new HashSet<tbCargos>();
            tbDepartamentosDept_UsuarioCreacionNavigation = new HashSet<tbDepartamentos>();
            tbDepartamentosDept_UsuarioModificaNavigation = new HashSet<tbDepartamentos>();
            tbEmpleadosEmpl_UsuarioCreacionNavigation = new HashSet<tbEmpleados>();
            tbEmpleadosEmpl_UsuarioModificaNavigation = new HashSet<tbEmpleados>();
            tbEstadosCivilesEsta_UsuarioCreacionNavigation = new HashSet<tbEstadosCiviles>();
            tbEstadosCivilesEsta_UsuarioModificaNavigation = new HashSet<tbEstadosCiviles>();
            tbMesasMesa_UsuarioCreacionNavigation = new HashSet<tbMesas>();
            tbMesasMesa_UsuarioModificaNavigation = new HashSet<tbMesas>();
            tbMunicipiosMuni_UsuarioCreacionNavigation = new HashSet<tbMunicipios>();
            tbMunicipiosMuni_UsuarioModificaNavigation = new HashSet<tbMunicipios>();
            tbPantallasPant_UsuarioCreacionNavigation = new HashSet<tbPantallas>();
            tbPantallasPant_UsuarioModificaNavigation = new HashSet<tbPantallas>();
            tbPartidosPart_UsuarioCreacionNavigation = new HashSet<tbPartidos>();
            tbPartidosPart_UsuarioModificaNavigation = new HashSet<tbPartidos>();
            tbPresidentesPres_UsuarioCreacionNavigation = new HashSet<tbPresidentes>();
            tbPresidentesPres_UsuarioModificaNavigation = new HashSet<tbPresidentes>();
            tbRolesRol_UsuarioCreacionNavigation = new HashSet<tbRoles>();
            tbRolesRol_UsuarioModificaNavigation = new HashSet<tbRoles>();
            tbSedesSede_UsuarioCreacionNavigation = new HashSet<tbSedes>();
            tbSedesSede_UsuarioModificaNavigation = new HashSet<tbSedes>();
            tbVotantesVota_UsuarioCreacionNavigation = new HashSet<tbVotantes>();
            tbVotantesVota_UsuarioModificaNavigation = new HashSet<tbVotantes>();
        }

        public int Usua_Id { get; set; }
        public string Usua_Usuario { get; set; }
        public string Usua_Contra { get; set; }
        public bool Usua_Admin { get; set; }
        public int Empl_Id { get; set; }
        public int Rol_Id { get; set; }
        public int Usua_UsuarioCreacion { get; set; }
        public DateTime Usua_FechaCreacion { get; set; }
        public int? Usua_UsuarioModifica { get; set; }
        public DateTime? Usua_FechaModifica { get; set; }
        public bool? Usua_Activo { get; set; }
        public string Usua_Imagen { get; set; }


        public virtual tbRoles Rol { get; set; }
        public virtual tbUsuarios Usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios Usua_UsuarioModificaNavigation { get; set; }
        public virtual ICollection<tbUsuarios> InverseUsua_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbUsuarios> InverseUsua_UsuarioModificaNavigation { get; set; }
        public virtual ICollection<tbAlcaldes> tbAlcaldesAlca_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbAlcaldes> tbAlcaldesAlca_UsuarioModificaNavigation { get; set; }
        public virtual ICollection<tbCargos> tbCargosCarg_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbCargos> tbCargosCarg_UsuarioModificaNavigation { get; set; }
        public virtual ICollection<tbDepartamentos> tbDepartamentosDept_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbDepartamentos> tbDepartamentosDept_UsuarioModificaNavigation { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleadosEmpl_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleadosEmpl_UsuarioModificaNavigation { get; set; }
        public virtual ICollection<tbEstadosCiviles> tbEstadosCivilesEsta_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbEstadosCiviles> tbEstadosCivilesEsta_UsuarioModificaNavigation { get; set; }
        public virtual ICollection<tbMesas> tbMesasMesa_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbMesas> tbMesasMesa_UsuarioModificaNavigation { get; set; }
        public virtual ICollection<tbMunicipios> tbMunicipiosMuni_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbMunicipios> tbMunicipiosMuni_UsuarioModificaNavigation { get; set; }
        public virtual ICollection<tbPantallas> tbPantallasPant_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPantallas> tbPantallasPant_UsuarioModificaNavigation { get; set; }
        public virtual ICollection<tbPartidos> tbPartidosPart_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPartidos> tbPartidosPart_UsuarioModificaNavigation { get; set; }
        public virtual ICollection<tbPresidentes> tbPresidentesPres_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPresidentes> tbPresidentesPres_UsuarioModificaNavigation { get; set; }
        public virtual ICollection<tbRoles> tbRolesRol_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbRoles> tbRolesRol_UsuarioModificaNavigation { get; set; }
        public virtual ICollection<tbSedes> tbSedesSede_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbSedes> tbSedesSede_UsuarioModificaNavigation { get; set; }
        public virtual ICollection<tbVotantes> tbVotantesVota_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbVotantes> tbVotantesVota_UsuarioModificaNavigation { get; set; }
    }
}