using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Votaciones.API.Controllers
{
    public class MesasPorSedesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
