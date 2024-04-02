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

        [HttpGet("List")]

        public IActionResult List()
        {

            var list = _generalServices.ListDepto();
            return Ok(list);
        }

        [HttpPost("Insert")]
        public IActionResult Create(DepartamentoViewModel json)
        {
            _mapper.Map<tbDepartamentos>(json);
            var modelo = new tbDepartamentos()
            {
                Dept_Codigo = json.Dept_Codigo,
                Dept_Descripcion = json.Dept_Descripcion,
                Dept_UsuarioCreacion = 2,
                Dept_FechaCreacion = DateTime.Now
            };
            var list = _generalServices.CrearDepto(modelo);
            return Ok(list);
        }
        [HttpPut("Update")]
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
        [HttpDelete("Delete")]
        public IActionResult Delete(DepartamentoViewModel json)
        {
            _mapper.Map<tbDepartamentos>(json);
            var modelo = new tbDepartamentos()
            {
                Dept_Codigo = json.Dept_Codigo
            };
            var list = _generalServices.EliminarDepto(modelo.Dept_Codigo);
            return Ok(list);
        }
    }
}
