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

        public PartidoController(VotacionesServices VotacionesServices, IMapper mapper)

        {

            _votacionesServices = VotacionesServices;
            _mapper = mapper;

        }

        [HttpGet("API/[controller]/List")]
        public IActionResult List()
        {

            var list = _votacionesServices.ListPartido();
            return Ok(list);
        }

        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(PartidoViewModel json)
        {
            _mapper.Map<tbPartidos>(json);
            var modelo = new tbPartidos()
            {
                Part_Descripcion = json.Part_Descripcion,
                Part_UsuarioCreacion = 2,
                Part_FechaCreacion = DateTime.Now,
                Part_Imagen = json.Part_Imagen
            };
            var list = _votacionesServices.CrearPartido(modelo);
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
                Part_UsuarioModifica = 2,
                Part_FechaModifica = DateTime.Now,
                Part_Imagen = json.Part_Imagen
            };
            var list = _votacionesServices.EditarPartido(modelo);
            return Ok(list);
        }

        [HttpDelete("API/[controller]/Delete")]
        public IActionResult Delete(PartidoViewModel json)
        {
            _mapper.Map<tbPartidos>(json);
            var modelo = new tbPartidos()
            {
                Part_Id = Convert.ToInt32(json.Part_Id)

            };
            var list = _votacionesServices.EliminarAlcalde(modelo.Part_Id);
            return Ok(list);
        }

    }
}
