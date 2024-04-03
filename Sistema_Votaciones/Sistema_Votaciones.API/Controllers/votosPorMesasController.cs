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
    public class votosPorMesasController : Controller
    {
        private readonly VotacionesServices _votacionesServices;
        private readonly IMapper _mapper;

        public votosPorMesasController(VotacionesServices VotacionesServices, IMapper mapper)

        {

            _votacionesServices = VotacionesServices;
            _mapper = mapper;

        }


        [HttpGet("API/[controller]/List")]
        public IActionResult List()
        {

            var list = _votacionesServices.ListVotosPorMesas();
            return Ok(list);
        }

        [HttpPost("API/[controller]/Insert")]
        public IActionResult Create(VotosPorMesasViewModel json)
        {
            _mapper.Map<tbVotosPorMesas>(json);
            var modelo = new tbVotosPorMesas()
            {
                MePS_Id = Convert.ToInt32(json.MePS_Id),
                VoMe_CandidatoId = Convert.ToInt32(json.VoMe_CandidatoId),
                VoMe_EsPresidente = json.VoMe_EsPresidente


            };
            var list = _votacionesServices.CrearVotosPorMesas(modelo);
            return Ok(list);
        }


        [HttpPut("API/[controller]/Update")]
        public IActionResult Update(VotosPorMesasViewModel json)
        {
            _mapper.Map<tbVotosPorMesas>(json);
            var modelo = new tbVotosPorMesas()
            {
                VoMe_Id = Convert.ToInt32(json.VoMe_Id),
                MePS_Id = Convert.ToInt32(json.MePS_Id),
                VoMe_CandidatoId = Convert.ToInt32(json.VoMe_CandidatoId),
                VoMe_EsPresidente = json.VoMe_EsPresidente

            };
            var list = _votacionesServices.EditarVotosPorMesas(modelo);
            return Ok(list);
        }

        [HttpDelete("API/[controller]/Delete")]
        public IActionResult Delete(VotosPorMesasViewModel json)
        {
            _mapper.Map<tbVotosPorMesas>(json);
            var modelo = new tbVotosPorMesas()
            {
                VoMe_Id = Convert.ToInt32(json.VoMe_Id)

            };
            var list = _votacionesServices.EliminarVotosPorMesas(modelo.VoMe_Id);
            return Ok(list);
        }
    }
}
