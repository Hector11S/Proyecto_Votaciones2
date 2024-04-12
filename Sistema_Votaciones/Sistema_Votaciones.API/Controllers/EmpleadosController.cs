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
    public class EmpleadosController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public EmpleadosController(GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _mapper = mapper;
        }

        [HttpGet("API/[controller]/List")]
        public IActionResult List()
        {

            var list = _generalServices.ListEmpl();
            return Ok(list);
        }
        [HttpGet("API/[controller]/FindByEmpl")]
        public IActionResult FindByEmpl(int Empl_Id)
        {
            var list = _generalServices.FindEmpleByEmpl(Empl_Id);
            return Ok(list);
        }

        [HttpGet("API/[controller]/Find")]
        public IActionResult Find(int Empl_Id)
        {
            var list = _generalServices.FindEmpl(Empl_Id);
            return Ok(list);
        }

        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(EmpleadosViewModel json)
        {
            _mapper.Map<tbEmpleados>(json);
            var modelo = new tbEmpleados()
            {
                Empl_Id = json.Empl_Id,
                Carg_Id = json.Carg_Id,
                Part_Id = json.Part_Id,
                Sede_Id = json.Sede_Id,
                Mesa_Id = json.Mesa_Id,
                Empl_UsuarioCreacion = json.Empl_UsuarioCreacion,
                Empl_FechaCreacion = json.Empl_FechaCreacion
            };
            var response = _generalServices.CrearEmpl(modelo);
            return Ok(response);
        }

        [HttpPut("API/[controller]/Update")]
        public IActionResult Update(EmpleadosViewModel json)
        {
            _mapper.Map<tbEmpleados>(json);
            var modelo = new tbEmpleados()
            {
                Empl_Id = json.Empl_Id,
                Carg_Id = json.Carg_Id,
                Part_Id = json.Part_Id,
                Sede_Id = json.Sede_Id,
                Mesa_Id = json.Mesa_Id,
                Empl_UsuarioModifica = json.Empl_UsuarioModifica,
                Empl_FechaModifica = json.Empl_FechaModifica
            };
            var list = _generalServices.EditarEmpl(modelo);
            return Ok(list);
        }
        [HttpPut("API/[controller]/Active")]
        public IActionResult Active(int Empl_Id)
        {
            var list = _generalServices.ActivarDesactivarEmpl(Empl_Id);
            return Ok(list);
        }

        [HttpGet("API/[controller]/ObtenerSedesPorMunicipio")]
        public IActionResult ObtenerSedesPorMunicipio(string muniCodigo)
        {
            var sedes = _generalServices.ObtenerSedesPorMunicipio(muniCodigo);
            return Ok(sedes);
        }

    }
}
