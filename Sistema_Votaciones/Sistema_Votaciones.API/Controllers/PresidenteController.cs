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
    public class PresidenteController : Controller
    {
        private readonly VotacionesServices _votacionesServices;
        private readonly IMapper _mapper;

        public PresidenteController(VotacionesServices VotacionesServices, IMapper mapper)

        {

            _votacionesServices = VotacionesServices;
            _mapper = mapper;

        }


        [HttpGet("API/[controller]/List")]
        public IActionResult List()
        {

            var list = _votacionesServices.ListPresidente();
            return Ok(list);
        }

        [HttpGet("API/[controller]/Find")]
        public IActionResult Find(int Pres_Id)
        {
            var result = _votacionesServices.BuscarPresidente(Pres_Id);
            return Ok(result);
        }

        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(PresidenteViewModel json)
        {
            _mapper.Map<tbPresidentes>(json);
            var modelo = new tbPresidentes()
            {
                Pres_Id = Convert.ToInt32(json.Pres_Id),
                Part_Id = Convert.ToInt32(json.Part_Id),
                Pres_Imagen = json.Pres_Imagen,
                Pres_UsuarioCreacion = json.Pres_UsuarioCreacion,
                Pres_FechaCreacion = json.Pres_FechaCreacion
            };
            var list = _votacionesServices.CrearPresidente(modelo);
            return Ok(list);
        }

        [HttpPut("API/[controller]/Update")]
        public IActionResult Update(PresidenteViewModel json)
        {
            _mapper.Map<tbPresidentes>(json);
            var modelo = new tbPresidentes()
            {
                Pres_Id = Convert.ToInt32(json.Pres_Id),
                Part_Id = Convert.ToInt32(json.Part_Id),
                Pres_Imagen = json.Pres_Imagen,
                Pres_UsuarioModifica = json.Pres_UsuarioModifica,
                Pres_FechaModifica = json.Pres_FechaModifica
            };
            var list = _votacionesServices.EditarPresidente(modelo);
            return Ok(list);
        }

        [HttpDelete("API/[controller]/Delete")]
        public IActionResult Delete(int Pres_Id)
        {
            var response = _votacionesServices.EliminarPresidente(Pres_Id);
            return Ok(response);
        }
    }
}
