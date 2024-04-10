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
        private readonly VotacionesServices _votacionesServices;
        private readonly IMapper _mapper;

        public PartidoController(VotacionesServices votacionesServices, IMapper mapper)
        {
            _votacionesServices = votacionesServices;
            _mapper = mapper;
        }

        [HttpGet("API/[controller]/List")]
        public IActionResult List()
        {

            var list = _votacionesServices.ListPart();
            return Ok(list);
        }
        [HttpGet("API/[controller]/Find")]
        public IActionResult Find(int Part_Id)
        {
            var list = _votacionesServices.BuscarPartido(Part_Id);
            return Ok(list);
        }

        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(PartidoViewModel json)
        {
            _mapper.Map<tbPartidos>(json);
            var modelo = new tbPartidos()
            {
                Part_Descripcion = json.Part_Descripcion,
                Part_Color = json.Part_Color,
                Part_Imagen = json.Part_Imagen,
                Part_UsuarioCreacion = json.Part_UsuarioCreacion,
                Part_FechaCreacion = json.Part_FechaCreacion
            };
            var response = _votacionesServices.CrearPart(modelo);
            return Ok(response);
        }
        [HttpPut("API/[controller]/Update")]
        public IActionResult Update(PartidoViewModel json)
        {
            _mapper.Map<tbPartidos>(json);
            var modelo = new tbPartidos()
            {
                Part_Id = json.Part_Id,
                Part_Descripcion = json.Part_Descripcion,
                Part_Color = json.Part_Color,
                Part_Imagen = json.Part_Imagen,
                Part_UsuarioModifica = json.Part_UsuarioModifica,
                Part_FechaModifica = json.Part_FechaModifica
            };
            var response = _votacionesServices.EditarPart(modelo);
            return Ok(response);
        }

        [HttpDelete("API/[controller]/Delete")]
        public IActionResult Delete(int Part_Id)
        {
            var response = _votacionesServices.DesactivarPartido(Part_Id);
            return Ok(response);
        }
    }
}
