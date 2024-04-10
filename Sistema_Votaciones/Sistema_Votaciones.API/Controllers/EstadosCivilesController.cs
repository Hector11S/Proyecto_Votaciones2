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
    public class EstadosCivilesController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public EstadosCivilesController(GeneralServices GeneralServices, IMapper mapper)
        {
            _generalServices = GeneralServices;
            _mapper = mapper;
        }

        [HttpGet("API/[controller]/List")]
        public IActionResult List()
        {

            var list = _generalServices.ListEsta();
            return Ok(list);
        }
        [HttpGet("API/[controller]/Find")]

        public IActionResult Find(int Esta_Id)
        {

            var list = _generalServices.ListEsta(Esta_Id);
            return Ok(list);
        }

        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(EstadosCivilesViewModel json)
        {
            _mapper.Map<tbEstadosCiviles>(json);
            var modelo = new tbEstadosCiviles()
            {
                Esta_Id = json.Esta_Id,
                Esta_Descripcion = json.Esta_Descripcion,
                Esta_UsuarioCreacion = json.Esta_UsuarioCreacion,
                Esta_FechaCreacion = json.Esta_FechaCreacion
            };
            var response = _generalServices.CrearEsta(modelo);
            return Ok(response);
        }
        [HttpPut("API/[controller]/Update")]
        public IActionResult Update(EstadosCivilesViewModel json)
        {
            _mapper.Map<tbEstadosCiviles>(json);
            var modelo = new tbEstadosCiviles()
            {
                Esta_Id = json.Esta_Id,
                Esta_Descripcion = json.Esta_Descripcion,
                Esta_UsuarioModifica = json.Esta_UsuarioModifica,
                Esta_FechaModifica = json.Esta_FechaModifica
            };
            var list = _generalServices.EditarEsta(modelo);
            return Ok(list);
        }
        [HttpDelete("API/[controller]/Delete")]
        public IActionResult Delete(int Esta_Id)
        {
            var list = _generalServices.EliminarEsta(Esta_Id);
            return Ok(list);
        }
    }
}
