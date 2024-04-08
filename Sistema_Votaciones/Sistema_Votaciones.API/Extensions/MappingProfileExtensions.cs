using AutoMapper;
using Sistema_Votaciones.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema_Votaciones.Common.Models;

namespace Sistema_Votaciones.API.Extensions
{
    public class MappingProfileExtensions : Profile
    {
        public MappingProfileExtensions()
        {
            CreateMap<UsuariosViewModel, tbUsuarios>().ReverseMap();
            CreateMap<RolesViewModel, tbRoles>().ReverseMap();
            CreateMap<PantallasViewModel, tbPantallas>().ReverseMap();
            CreateMap<PantallasPorRolesViewModel, tbPantallasPorRoles>().ReverseMap();
            CreateMap<MunicipioViewModel, tbMunicipios>().ReverseMap();
            CreateMap<CargosViewModel, tbCargos>().ReverseMap();
            CreateMap<EstadosCivilesViewModel, tbEstadosCiviles>().ReverseMap();
            CreateMap<SedesViewModel, tbSedes>().ReverseMap();
            CreateMap<EmpleadosViewModel, tbEmpleados>().ReverseMap();
            CreateMap<MesasViewModel, tbMesas>().ReverseMap();
            CreateMap<VotanteViewModel, tbVotantes>().ReverseMap();
            CreateMap<PartidoViewModel, tbPartidos>().ReverseMap();
            CreateMap<AlcaldeViewModel, tbAlcaldes>().ReverseMap();
            CreateMap<PresidenteViewModel, tbPresidentes>().ReverseMap();
            CreateMap<VotosPorMesasViewModel, tbVotosPorMesas>().ReverseMap();
        }
    }
}
