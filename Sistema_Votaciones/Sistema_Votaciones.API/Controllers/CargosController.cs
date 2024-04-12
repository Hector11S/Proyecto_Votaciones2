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
    public class CargosController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public CargosController(GeneralServices GeneralServices, IMapper mapper)
        {
            _generalServices = GeneralServices;
            _mapper = mapper;
        }

        [HttpGet("API/[controller]/List")]
        public IActionResult List()
        {

            var list = _generalServices.ListCargo();
            return Ok(list);
        }
        [HttpGet("API/[controller]/Find")]

        public IActionResult Find(int Carg_Id)
        {

            var list = _generalServices.ListCargo(Carg_Id);
            return Ok(list);
        }

        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(CargosViewModel json)
        {
            _mapper.Map<tbCargos>(json);
            var modelo = new tbCargos()
            {
     
                Carg_Descripcion = json.Carg_Descripcion,
                Carg_UsuarioCreacion = json.Carg_UsuarioCreacion,
                Carg_FechaCreacion = json.Carg_FechaCreacion
            };
            var response = _generalServices.CrearCargo(modelo);
            return Ok(response);
        }
        [HttpPut("API/[controller]/Update")]
        public IActionResult Update(CargosViewModel json)
        {
            _mapper.Map<tbCargos>(json);
            var modelo = new tbCargos()
            {
                Carg_Id = json.Carg_Id,
                Carg_Descripcion = json.Carg_Descripcion,
                Carg_UsuarioModifica = json.Carg_UsuarioModifica,
                Carg_FechaModifica = json.Carg_FechaModifica
            };
            var list = _generalServices.EditarCargo(modelo);
            return Ok(list);
        }
        [HttpDelete("API/[controller]/Delete")]
        public IActionResult Delete(int Carg_Id)
        {
            var list = _generalServices.EliminarCargo(Carg_Id);
            return Ok(list);
        }
    }
}
