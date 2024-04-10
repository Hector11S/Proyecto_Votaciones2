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
    public class MesasController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public MesasController(GeneralServices GeneralServices, IMapper mapper)
        {
            _generalServices = GeneralServices;
            _mapper = mapper;
        }

        [HttpGet("API/[controller]/List")]
        public IActionResult List()
        {

            var list = _generalServices.ListMesa();
            return Ok(list);
        }
        [HttpGet("API/[controller]/Find")]

        public IActionResult Find(int Mesa_Id)
        {

            var list = _generalServices.ListMesa(Mesa_Id);
            return Ok(list);
        }

        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(MesasViewModel json)
        {
            _mapper.Map<tbMesas>(json);
            var modelo = new tbMesas()
            {
                Mesa_Id = json.Mesa_Id,
                Mesa_Numero = json.Mesa_Numero,
                Mesa_UsuarioCreacion = json.Mesa_UsuarioCreacion,
                Mesa_FechaCreacion = json.Mesa_FechaCreacion
            };
            var response = _generalServices.CrearMesa(modelo);
            return Ok(response);
        }
        [HttpPut("API/[controller]/Update")]
        public IActionResult Update(MesasViewModel json)
        {
            _mapper.Map<tbMesas>(json);
            var modelo = new tbMesas()
            {
                Mesa_Id = json.Mesa_Id,
                Mesa_Numero = json.Mesa_Numero,
                Mesa_UsuarioModifica = json.Mesa_UsuarioModifica,
                Mesa_FechaModifica = json.Mesa_FechaModifica
            };
            var list = _generalServices.EditarMesa(modelo);
            return Ok(list);
        }
        [HttpDelete("API/[controller]/Delete")]
        public IActionResult Delete(int Mesa_Id)
        {
            var list = _generalServices.EliminarMesa(Mesa_Id);
            return Ok(list);
        }
    }
}
