using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class AlcaldeController : Controller
    {
        public AlcaldeServicios _alcaldeServicios;
        public AlcaldeController(AlcaldeServicios alcaldeServicios)
        {
            _alcaldeServicios = alcaldeServicios;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<AlcaldeViewModel>();
                var list = await _alcaldeServicios.ObtenerAlcaldeList();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet("[controller]/Details/{Alca_Id}")]
        public async Task<IActionResult> Details(string Alca_Id)
        {
            try
            {
                var model = new AlcaldeViewModel();
                var list = await _alcaldeServicios.ObtenerAlcalde(Alca_Id);
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AlcaldeViewModel item)
        {
            try
            {
                item.Alca_UsuarioCreacion = 2;
                item.Alca_FechaCreacion = DateTime.Now;
                var result = await _alcaldeServicios.CrearAlcalde(item);
                if (result.Success)
                {
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                //return View(item);
            }
            return View(item);
        }
        [HttpGet("[controller]/Edit/{Dept_Codigo}")]
        public async Task<IActionResult> Edit(string Alca_Id)
        {
            try
            {
                var model = await _alcaldeServicios.ObtenerAlcalde(Alca_Id);
                return Json(model.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("[controller]/Edit")]
        public async Task<IActionResult> Edit(AlcaldeViewModel item)
        {
            try
            {
                item.Alca_UsuarioCreacion = 2;
                item.Alca_FechaCreacion = DateTime.Now;
                var result = await _alcaldeServicios.EditarAlcalde(item);
                if (result.Success)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Index", item);
                }
            }
            catch (Exception ex)
            {
                return View(item);
                throw;
            }
        }
    }
}
