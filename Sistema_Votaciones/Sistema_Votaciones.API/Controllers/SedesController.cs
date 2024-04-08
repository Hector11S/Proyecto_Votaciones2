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
    public class SedesController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public SedesController(GeneralServices GeneralServices, IMapper mapper)
        {
            _generalServices = GeneralServices;
            _mapper = mapper;
        }

        [HttpGet("API/[controller]/List")]
        public IActionResult List()
        {

            var list = _generalServices.ListSede();
            return Ok(list);
        }
        [HttpGet("API/[controller]/Find")]

        public IActionResult Find(int Sede_Id)
        {

            var list = _generalServices.ListSede(Sede_Id);
            return Ok(list);
        }

        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(SedesViewModel json)
        {
            _mapper.Map<tbSedes>(json);
            var modelo = new tbSedes()
            {
                Sede_Id = json.Sede_Id,
                Sede_Descripcion = json.Sede_Descripcion,
                Muni_Codigo = json.Muni_Codigo,
                Sede_UsuarioCreacion = json.Sede_UsuarioCreacion,
                Sede_FechaCreacion = json.Sede_FechaCreacion
            };
            var response = _generalServices.CrearSede(modelo);
            return Ok(response);
        }
        [HttpPut("API/[controller]/Update")]
        public IActionResult Update(SedesViewModel json)
        {
            _mapper.Map<tbSedes>(json);
            var modelo = new tbSedes()
            {
                Sede_Id = json.Sede_Id,
                Sede_Descripcion = json.Sede_Descripcion,
                Muni_Codigo = json.Muni_Codigo,
                Sede_UsuarioModifica = json.Sede_UsuarioModifica,
                Sede_FechaModifica = json.Sede_FechaModifica
            };
            var list = _generalServices.EditarSede(modelo);
            return Ok(list);
        }
        [HttpDelete("API/[controller]/Delete")]
        public IActionResult Delete(int Sede_Id)
        {
            var list = _generalServices.EliminarSede(Sede_Id);
            return Ok(list);
        }
    }
}
