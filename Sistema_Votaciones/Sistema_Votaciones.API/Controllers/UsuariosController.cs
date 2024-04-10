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
    public class UsuariosController : Controller
    {
        private readonly AccesoServices _accesoServices;
        private readonly IMapper _mapper;

        public UsuariosController(AccesoServices accesoServices, IMapper mapper)
        {
            _accesoServices = accesoServices;
            _mapper = mapper;
        }

        [HttpGet("API/[controller]/List")]
        public IActionResult List()
        {

            var list = _accesoServices.ListUsua();
            return Ok(list);
        }

        [HttpGet("API/[controller]/Find")]
        public IActionResult Find(int Usua_Id)
        {
            var list = _accesoServices.FindUsua(Usua_Id);
            return Ok(list);
        }

        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(UsuariosViewModel json)
        {
            _mapper.Map<tbUsuarios>(json);
            var modelo = new tbUsuarios()
            {
                Usua_Id = json.Usua_Id,
                Usua_Usuario = json.Usua_Usuario,
                Usua_Contra = json.Usua_Contra,
                Empl_Id = json.Empl_Id,
                Rol_Id = json.Rol_Id,
                Usua_Admin = json.Usua_Admin,
                Usua_UsuarioCreacion = json.Usua_UsuarioCreacion,
                Usua_FechaCreacion = json.Usua_FechaCreacion
            };
            var response = _accesoServices.CrearUsua(modelo);
            return Ok(response);
        }
        [HttpPut("API/[controller]/Update")]
        public IActionResult Update(UsuariosViewModel json)
        {
            _mapper.Map<tbUsuarios>(json);
            var modelo = new tbUsuarios()
            {
                Usua_Id = json.Usua_Id,
                Usua_Usuario = json.Usua_Usuario,
                Empl_Id = json.Empl_Id,
                Rol_Id = json.Rol_Id,
                Usua_Admin = json.Usua_Admin,
                Usua_UsuarioModifica = json.Usua_UsuarioModifica,
                Usua_FechaModifica = json.Usua_FechaModifica
            };
            var list = _accesoServices.EditarUsua(modelo);
            return Ok(list);
        }
        [HttpPut("API/[controller]/Active")]
        public IActionResult Active(int Usua_Id)
        {
            var list = _accesoServices.ActivarDesactivarUsua(Usua_Id);
            return Ok(list);
        }
    }
}
