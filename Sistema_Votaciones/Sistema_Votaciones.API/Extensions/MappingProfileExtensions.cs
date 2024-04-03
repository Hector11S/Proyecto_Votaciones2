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
            CreateMap<DepartamentoViewModel, tbDepartamentos>().ReverseMap();

            CreateMap<AlcaldeViewModel, tbAlcaldes>().ReverseMap();

            CreateMap<VotosPorMesasViewModel, tbVotosPorMesas>().ReverseMap();
        }
    }
}
