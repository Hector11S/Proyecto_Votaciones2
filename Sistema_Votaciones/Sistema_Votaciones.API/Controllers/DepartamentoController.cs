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
    public class DepartamentoController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public DepartamentoController(GeneralServices GeneralServices, IMapper mapper)

        {

            _generalServices = GeneralServices;
            _mapper = mapper;

        }

        [HttpGet("API/[controller]/List")]

        public IActionResult List()
        {

            var list = _generalServices.ListDepto();
            return Ok(list);
        }
        [HttpGet("API/[controller]/Fill")]

        public IActionResult Fill(string Dept_Codigo)
        {

            var list = _generalServices.ListDepto(Dept_Codigo);
            return Ok(list);
        }

        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(DepartamentoViewModel json)
        {
            _mapper.Map<tbDepartamentos>(json);
            var modelo = new tbDepartamentos()
            {
                Dept_Codigo = json.Dept_Codigo,
                Dept_Descripcion = json.Dept_Descripcion,
                Dept_UsuarioCreacion = json.Dept_UsuarioCreacion,
                Dept_FechaCreacion = json.Dept_FechaCreacion
            };
            var list = _generalServices.CrearDepto(modelo);
            return Ok(list);
        }
        [HttpPut("API/[controller]/Update")]
        public IActionResult Update(DepartamentoViewModel json)
        {
            _mapper.Map<tbDepartamentos>(json);
            var modelo = new tbDepartamentos()
            {
                Dept_Codigo = json.Dept_Codigo,
                Dept_Descripcion = json.Dept_Descripcion,
                Dept_UsuarioModifica = 2,
                Dept_FechaModifica = DateTime.Now
            };
            var list = _generalServices.EditarDepto(modelo);
            return Ok(list);
        }
        [HttpDelete("API/[controller]/Delete")]
        public IActionResult Delete(string Dept_Codigo)
        {
            var list = _generalServices.EliminarDepto(Dept_Codigo);
            return Ok(list);
        }
    }
}
