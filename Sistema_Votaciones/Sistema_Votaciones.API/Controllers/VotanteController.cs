using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sistema_Votaciones.BusinessLogic.Services;
using Sistema_Votaciones.Common.Models;
using Sistema_Votaciones.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Votaciones.API.Controllers
{
    [ApiController]
    public class VotanteController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public VotanteController(GeneralServices GeneralServices, IMapper mapper)
        {
            _generalServices = GeneralServices;
            _mapper = mapper;
        }
        [HttpGet("API/[controller]/List")]
        public IActionResult List()
        {

            var list = _generalServices.ListVotante();
            return Ok(list);
        }

        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(VotanteViewModel json)
        {
            _mapper.Map<tbVotantes>(json);
            var modelo = new tbVotantes()
            {

                Vota_Nombre = json.Vota_Nombre,
                Vota_Apellidos = json.Vota_Apellidos,
                Vota_DNI = json.Vota_DNI,
                Vota_YaVoto = json.Vota_YaVoto,
                Muni_Codigo = json.Muni_Codigo,
                Esta_Id = json.Esta_Id,
                MePS_Id = json.MePS_Id,
                Vota_UsuarioCreacion = json.Vota_UsuarioCreacion,
                Vota_FechaCreacion = json.Vota_FechaCreacion
            };
            var list = _generalServices.CrearVotante(modelo);
            return Ok(list);
        }


        [HttpPut("API/[controller]/Update")]
        public IActionResult Update(VotanteViewModel json)
        {
            _mapper.Map<tbVotantes>(json);
            var modelo = new tbVotantes()
            {
                Vota_Id = json.Vota_Id,
                Vota_Nombre = json.Vota_Nombre,
                Vota_Apellidos = json.Vota_Apellidos,
                Vota_DNI = json.Vota_DNI,
                Vota_YaVoto = json.Vota_YaVoto,
                Muni_Codigo = json.Muni_Codigo,
                Esta_Id = json.Esta_Id,
                MePS_Id = json.MePS_Id,
                Vota_UsuarioModifica = json.Vota_UsuarioModifica,
                Vota_FechaModifica = json.Vota_FechaModifica
            };
            var list = _generalServices.EditarVotante(modelo);
            return Ok(list);
        }

        [HttpGet("API/[controller]/Find")]
        public IActionResult Find(string Vota_DNI)
        {
            var result = _generalServices.BuscarVotantePorDNI(Vota_DNI);
            return Ok(result);
        }
    }
}
