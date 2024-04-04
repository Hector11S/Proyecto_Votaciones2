using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sistema_Votaciones.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Votaciones.API.Controllers
{
    [ApiController]
    public class VotanteController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public VotanteController(GeneralServices GeneralServices, IMapper mapper)
        {
            _generalServices = GeneralServices;
            _mapper = mapper;
        }
        [HttpGet("API/[controller]/Find")]
        public IActionResult Find(string Vota_DNI)
        {

            var list = _generalServices.FindVotante(Vota_DNI);
            return Ok(list);
        }
    }
}
