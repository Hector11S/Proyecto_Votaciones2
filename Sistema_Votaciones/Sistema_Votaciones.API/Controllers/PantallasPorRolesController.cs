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
    public class PantallasPorRolesController : Controller
    {
        private readonly AccesoServices _accesoServices;
        private readonly IMapper _mapper;

        public PantallasPorRolesController(AccesoServices accesoServices, IMapper mapper)
        {
            _accesoServices = accesoServices;
            _mapper = mapper;
        }

        [HttpGet("API/[controller]/List")]
        public IActionResult List()
        {

            var list = _accesoServices.ListParo();
            return Ok(list);
        }

        [HttpGet("API/[controller]/Find")]
        public IActionResult Find(int Rol_Id)
        {

            var list = _accesoServices.ListParo(Rol_Id);
            return Ok(list);
        }


        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(PantallasPorRolesViewModel json)
        {
            _mapper.Map<tbPantallasPorRoles>(json);
            var modelo = new tbPantallasPorRoles()
            {
                Rol_Id = json.Rol_Id,
                Pant_Id = json.Pant_Id
            };
            var response = _accesoServices.CrearParo(modelo);
            return Ok(response);
        }

        [HttpDelete("API/[controller]/Delete")]
        public IActionResult Delete(int Rol_Id, int Pant_Id)
        {
            var list = _accesoServices.EliminarParo(Rol_Id, Pant_Id);
            return Ok(list);
        }

        [HttpPost("API/[controller]/CreatePorEsqu")]
        public IActionResult CreatePorEsqu(PantallasPorRolesViewModel json)
        {
            _mapper.Map<tbPantallasPorRoles>(json);
            var modelo = new tbPantallasPorRoles()
            {
                Rol_Id = json.Rol_Id,
                Esqu_Id = json.Esqu_Id
            };
            var response = _accesoServices.CrearParoPorEsqu(modelo);
            return Ok(response);
        }

        [HttpDelete("API/[controller]/DeletePorEsqu")]
        public IActionResult DeletePorEsqu(int Rol_Id, int Esqu_Id)
        {
            var list = _accesoServices.EliminarParoPorEsqu(Rol_Id, Esqu_Id);
            return Ok(list);
        }
    }
}
