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
    public class PartidoController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public PartidoController(GeneralServices GeneralServices, IMapper mapper)
        {
            _generalServices = GeneralServices;
            _mapper = mapper;
        }

        [HttpGet("API/[controller]/List")]
        public IActionResult List()
        {

            var list = _generalServices.ListPart();
            return Ok(list);
        }
        [HttpGet("API/[controller]/Find")]

        public IActionResult Find(string Dept_Codigo)
        {

            var list = _generalServices.ListPart(Dept_Codigo);
            return Ok(list);
        }

        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(PartidoViewModel json)
        {
            _mapper.Map<tbPartidos>(json);
            var modelo = new tbPartidos()
            {
                Part_Id = json.Part_Id,
                Part_Descripcion = json.Part_Descripcion,
                Part_UsuarioCreacion = json.Part_UsuarioCreacion,
                Part_FechaCreacion = json.Part_FechaCreacion
            };
            var list = _generalServices.CrearPart(modelo);
            return Ok(list);
        }
        [HttpPut("API/[controller]/Update")]
        public IActionResult Update(PartidoViewModel json)
        {
            _mapper.Map<tbPartidos>(json);
            var modelo = new tbPartidos()
            {
                Part_Id = json.Part_Id,
                Part_Descripcion = json.Part_Descripcion,
                Part_UsuarioModifica = json.Part_UsuarioModifica,
                Part_FechaModifica = json.Part_FechaModifica
            };
            var list = _generalServices.EditarPart(modelo);
            return Ok(list);
        }
    }
