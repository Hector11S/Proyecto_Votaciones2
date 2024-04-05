using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly VotanteServicios _votanteServicios;

        public HomeController(ILogger<HomeController> logger, VotanteServicios votanteServicios)
        {
            _logger = logger;
            _votanteServicios = votanteServicios;
        }
        [HttpGet("[controller]/ObtenerVotantePorDNI")]
        public async Task<IActionResult> ObtenerVotantePorDNI(string Vota_DNI)
        {
            try
            {
                var response = await _votanteServicios.ObtenerVotantePorDNI(Vota_DNI);
                if (response.Data == null)
                {
                    TempData["Advertencia"] = response.Message;
                    return RedirectToAction("Index");
                }
                else
                {
                    var votante = (VotanteViewModel)response.Data;
                    if (votante.Vota_YaVoto == true)
                    {
                        TempData["Advertencia"] = "Usted ya votó";
                        return RedirectToAction("Index");
                    }
                    return RedirectToAction("Create", "VotosPorMesa");
                }
            }
            catch (Exception ex)
            {
                return Json("Error de capa 8");
            }
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
