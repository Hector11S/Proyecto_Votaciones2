using Frontend_Sistema_Votaciones.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class VotanteController : Controller
    {
        public VotanteServicios _votanteServicios;
        public VotanteController(VotanteServicios votanteServicios)
        {
            _votanteServicios = votanteServicios;
        }

        [HttpPost]
        public async Task<IActionResult> BuscarVotante(string dni)
        {
            try
            {
                var existeVotante = await _votanteServicios.ExisteVotante(dni);
                if (existeVotante)
                {

                    return Json(new { redirectUrl = Url.Action("Votar", "Votacion", new { dni = dni }) });
                }
                else
                {

                    return Json(new { redirectUrl = Url.Action("Registro", "Votante", new { dni = dni }) });
                }
            }
            catch (Exception ex)
            {

                return Json(new { error = ex.Message });
            }
        }

    }
}
