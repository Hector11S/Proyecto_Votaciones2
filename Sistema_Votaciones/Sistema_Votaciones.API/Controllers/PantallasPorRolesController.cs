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


        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(PantallasPorRolesViewModel json)
        {
            _mapper.Map<tbPantallasPorRoles>(json);
            var modelo = new tbPantallasPorRoles()
            {
                Paro_Id = json.Paro_Id,
                
            };
            var response = _accesoServices.CrearParo(modelo);
            return Ok(response);
        }

        [HttpDelete("API/[controller]/Delete")]
        public IActionResult Delete(int Rol_Id, int Paro_Id)
        {
            var list = _accesoServices.EliminarParo(Rol_Id, Paro_Id);
            return Ok(list);
        }
    }
}
