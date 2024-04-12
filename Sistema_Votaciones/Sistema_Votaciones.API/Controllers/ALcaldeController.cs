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

        public ALcaldeController(VotacionesServices votacionesServices, IMapper mapper)

        {

            _votacionesServices = votacionesServices;
            _mapper = mapper;

        }


        [HttpGet("API/[controller]/Listar")]
        public IActionResult Listar(string Vota_DNI)
        {
            var list = _votacionesServices.ListAlcaldePorDNI(Vota_DNI);
            return Ok(list);
        }

        
        [HttpGet("API/[controller]/List")]
        public IActionResult List()
        {

            var list = _votacionesServices.ListAlcalde();
            return Ok(list);
        }

        [HttpGet("API/[controller]/Find")]
        public IActionResult Find(int Alca_Id)
        {
            var result = _votacionesServices.BuscarAlcalde(Alca_Id);
            return Ok(result);
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
                Alca_UsuarioCreacion = json.Alca_UsuarioCreacion,
                Alca_FechaCreacion = json.Alca_FechaCreacion
            };
            var response = _votacionesServices.CrearAlcalde(modelo);
            return Ok(response);
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
                Alca_UsuarioModifica = json.Alca_UsuarioModifica,
                Alca_FechaModifica = json.Alca_FechaModifica
            };
            var response = _votacionesServices.EditarAlcalde(modelo);
            return Ok(response);
        }

        [HttpDelete("API/[controller]/Delete")]
        public IActionResult Delete(AlcaldeViewModel json)
        {
            _mapper.Map<tbAlcaldes>(json);
            var modelo = new tbAlcaldes()
            {
                Alca_Id = Convert.ToInt32(json.Alca_Id)

            };
            var response = _votacionesServices.EliminarAlcalde(modelo.Alca_Id);
            return Ok(response);
        }
    }
}
