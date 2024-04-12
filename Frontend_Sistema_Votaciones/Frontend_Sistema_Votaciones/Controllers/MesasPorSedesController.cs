using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.Servicios;
using Frontend_Sistema_Votaciones.WebAPI;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class MesasPorSedesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
