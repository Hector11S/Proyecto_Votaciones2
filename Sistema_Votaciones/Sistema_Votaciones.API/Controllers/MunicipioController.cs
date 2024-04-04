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
    public class MunicipioController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public MunicipioController(GeneralServices GeneralServices, IMapper mapper)
        {
            _generalServices = GeneralServices;
            _mapper = mapper;
        }

        [HttpGet("API/[controller]/List")]
        public IActionResult List()
        {

            var list = _generalServices.ListMuni();
            return Ok(list);
        }
        [HttpGet("API/[controller]/Find")]

        public IActionResult Find(string Dept_Codigo)
        {

            var list = _generalServices.ListMuni(Dept_Codigo);
            return Ok(list);
        }

        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(MunicipioViewModel json)
        {
            _mapper.Map<tbMunicipios>(json);
            var modelo = new tbMunicipios()
            {
                Muni_Codigo = json.Muni_Codigo,
                Muni_Descripcion = json.Muni_Descripcion,
                Muni_UsuarioCreacion = json.Muni_UsuarioCreacion,
                Muni_FechaCreacion = json.Muni_FechaCreacion
            };
            var list = _generalServices.CrearMuni(modelo);
            return Ok(list);
        }
        [HttpPut("API/[controller]/Update")]
        public IActionResult Update(MunicipioViewModel json)
        {
            _mapper.Map<tbMunicipios>(json);
            var modelo = new tbMunicipios()
            {
                Muni_Codigo = json.Muni_Codigo,
                Muni_Descripcion = json.Muni_Descripcion,
                Muni_UsuarioModifica = json.Muni_UsuarioModifica,
                Muni_FechaModifica = json.Muni_FechaModifica
            };
            var list = _generalServices.EditarMuni(modelo);
            return Ok(list);
        }
        [HttpDelete("API/[controller]/Delete")]
        public IActionResult Delete(string Muni_Codigo)
        {
            var list = _generalServices.EliminarMuni(Muni_Codigo);
            return Ok(list);
        }
    }
}
