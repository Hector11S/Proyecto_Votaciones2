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

        [HttpGet("API/[controller]/FindByEmpl")]
        public IActionResult FindByEmpl(int Empl_Id)
        {
            var list = _accesoServices.FindUsuaByEmpl(Empl_Id);
            return Ok(list);
        }

        [HttpPost("API/[controller]/IniciarSesion")]
        public IActionResult IniciarSesion(UsuariosViewModel json)
        {
            _mapper.Map<tbUsuarios>(json);
            var modelo = new tbUsuarios()
            {
                Usua_Usuario = json.Usua_Usuario,
                Usua_Contra = json.Usua_Contra
            };
            var response = _accesoServices.IniciarSesion(modelo);
            
            //if (response.Data != null)
            //{
            //    var usuario = (tbUsuarios) response.Data;
            //    var modeloRespuesta = new UsuariosViewModel()
            //    {
            //        Usua_Id = usuario.Usua_Id,
            //        Usua_Usuario = usuario.Usua_Usuario,
            //        Usua_Contra = usuario.Usua_Contra,
            //        Vota_NombreCompleto = usuario.Vota_NombreCompleto,
            //        Usua_Admin = usuario.Usua_Admin,
            //        Empl_Id = usuario.Empl_Id,
            //        Rol_Id = usuario.Rol_Id,
            //        Usua_UsuarioCreacion = usuario.Usua_UsuarioCreacion,
            //        Usua_FechaCreacion = usuario.Usua_FechaCreacion,
            //        Usua_UsuarioModifica = usuario.Usua_UsuarioModifica,
            //        Usua_FechaModifica = usuario.Usua_FechaModifica,
            //        Usua_Activo = usuario.Usua_Activo,
            //        Usua_Imagen = usuario.Usua_Imagen,
            //        Muni_Codigo = usuario.Muni_Codigo
            //    };
            //    response.Data = modeloRespuesta;
            //}
            return Ok(response);
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
                Usua_FechaCreacion = json.Usua_FechaCreacion,
                Usua_Imagen = json.Usua_Imagen
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
                Usua_FechaModifica = json.Usua_FechaModifica,
                Usua_Imagen = json.Usua_Imagen
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
