using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.Servicios;
using Microsoft.AspNetCore.Http;
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

        private readonly AlcaldeServicios _alcaldeServicios;

        public HomeController(ILogger<HomeController> logger, VotanteServicios votanteServicios, AlcaldeServicios alcaldeServicios)
        {
            _logger = logger;
            _votanteServicios = votanteServicios;
            _alcaldeServicios = alcaldeServicios;
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

                    string fechaNacimientoStr = Vota_DNI.Substring(4, 4);
                    int fechaNacimiento = int.Parse(fechaNacimientoStr);

                    if (fechaNacimiento > 2006)
                    {
                        TempData["Advertencia"] = "Usted es menor de edad.";
                        return RedirectToAction("Index");
                    }

                    if (!votante.Vota_Permitido)
                    {
                        TempData["Advertencia"] = "No está habilitado para votar.";
                        return RedirectToAction("Index");
                    }

                    if (votante.Vota_YaVoto)
                    {
                        TempData["Advertencia"] = "Usted ya votó";
                        return RedirectToAction("Index");
                    }

                    var resultYaVoto = await _votanteServicios.MarcarVotanteComoYaVoto(Vota_DNI);
                    return RedirectToAction("Create", "VotosPorMesa", new { Vota_DNI = Vota_DNI });

                }
            }
            catch (Exception ex)
            {
                return Json("Error de capa 8");
            }
        }


        public IActionResult Index()
        {
            var rol = HttpContext.Session.GetInt32("Rol_Id");
            if (rol == null)
            {
                return View();
            }
            else
            {
                TempData["Advertencia"] = "Los asistentes electorales no pueden acceder a votar.";
                return RedirectToAction("Index", "VotosPorMesa");
            }
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
