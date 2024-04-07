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
    public class RolesController : Controller
    {
        private readonly AccesoServices _accesoServices;
        private readonly IMapper _mapper;

        public RolesController(AccesoServices accesoServices, IMapper mapper)
        {
            _accesoServices = accesoServices;
            _mapper = mapper;
        }

        [HttpGet("API/[controller]/List")]
        public IActionResult List()
        {

            var list = _accesoServices.ListRol();
            return Ok(list);
        }

        [HttpGet("API/[controller]/Find")]
        public IActionResult Find(int Rol_Id)
        {
            var list = _accesoServices.FindRol(Rol_Id);
            return Ok(list);
        }

        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(RolesViewModel json)
        {
            _mapper.Map<tbRoles>(json);
            var modelo = new tbRoles()
            {
                Rol_Id = json.Rol_Id,
                Rol_Descripcion = json.Rol_Descripcion,
                Rol_UsuarioCreacion = json.Rol_UsuarioCreacion,
                Rol_FechaCreacion = json.Rol_FechaCreacion
            };
            var response = _accesoServices.CrearRol(modelo);
            return Ok(response);
        }
        [HttpPut("API/[controller]/Update")]
        public IActionResult Update(RolesViewModel json)
        {
            _mapper.Map<tbRoles>(json);
            var modelo = new tbRoles()
            {
                Rol_Id = json.Rol_Id,
                Rol_Descripcion = json.Rol_Descripcion,
                Rol_UsuarioModifica = json.Rol_UsuarioModifica,
                Rol_FechaModifica = json.Rol_FechaModifica
            };
            var list = _accesoServices.EditarRol(modelo);
            return Ok(list);
        }
        [HttpDelete("API/[controller]/Delete")]
        public IActionResult Delete(int Rol_Id)
        {
            var list = _accesoServices.EliminarRol(Rol_Id);
            return Ok(list);
        }
    }
}
