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
    public class ALcaldeController : Controller
    {
        private readonly VotacionesServices _votacionesServices;
        private readonly IMapper _mapper;

        public ALcaldeController(VotacionesServices VotacionesServices, IMapper mapper)

        {

            _votacionesServices = VotacionesServices;
            _mapper = mapper;

        }


        [HttpGet("API/[controller]/List")]
        public IActionResult List()
        {

            var list = _votacionesServices.ListAlcalde();
            return Ok(list);
        }

        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(AlcaldeViewModel json)
        {
            _mapper.Map<tbAlcaldes>(json);
            var modelo = new tbAlcaldes()
            {
                Alca_Id = Convert.ToInt32(json.Alca_Id),
                Part_Id = Convert.ToInt32(json.Part_Id),
                Muni_Codigo = json.Muni_Codigo,
                Alca_Imagen = json.Alca_Imagen,
                Alca_UsuarioCreacion = 2,
                Alca_FechaCreacion = DateTime.Now
            };
            var list = _votacionesServices.CrearAlcalde(modelo);
            return Ok(list);
        }

        [HttpPut("API/[controller]/Update")]
        public IActionResult Update(AlcaldeViewModel json)
        {
            _mapper.Map<tbAlcaldes>(json);
            var modelo = new tbAlcaldes()
            {
                Alca_Id = Convert.ToInt32(json.Alca_Id),
                Part_Id = Convert.ToInt32(json.Part_Id),
                Muni_Codigo = json.Muni_Codigo,
                Alca_Imagen = json.Alca_Imagen,
                Alca_UsuarioModifica = 2,
                Alca_FechaModifica = DateTime.Now
            };
            var list = _votacionesServices.EditarAlcalde(modelo);
            return Ok(list);
        }

        [HttpDelete("API/[controller]/Delete")]
        public IActionResult Delete(AlcaldeViewModel json)
        {
            _mapper.Map<tbAlcaldes>(json);
            var modelo = new tbAlcaldes()
            {
                Alca_Id = Convert.ToInt32(json.Alca_Id)

            };
            var list = _votacionesServices.EliminarAlcalde(modelo.Alca_Id);
            return Ok(list);
        }
    }
}
