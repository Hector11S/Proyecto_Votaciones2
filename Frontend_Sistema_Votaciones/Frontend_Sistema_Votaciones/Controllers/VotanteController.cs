using Frontend_Sistema_Votaciones.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class VotanteController : Controller
    {
        private readonly VotanteServicios _votanteServicios;
        public VotanteController(VotanteServicios votanteServicios)
        {
            _votanteServicios = votanteServicios;
        }

        [HttpGet("[controller]/ObtenerVotantePorDNI/{Vota_DNI}")]
        public async Task<IActionResult> ObtenerVotantePorDNI(string Vota_DNI)
        {
            try
            {
                var model = await _votanteServicios.ObtenerVotantePorDNI(Vota_DNI);
                return Json(model.Data);
            }
            catch (Exception ex)
            {
                return Json("Error de capa 8");
            }
        }
        // GET: VotanteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: VotanteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VotanteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VotanteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VotanteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VotanteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VotanteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VotanteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
