using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class MunicipioController : Controller
    {
        public MunicipioServicios _MunicipioServicios;
        public MunicipioController(MunicipioServicios MunicipioServicios)
        {
            _MunicipioServicios = MunicipioServicios;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<MunicipioViewModel>();
                var list = await _MunicipioServicios.ObtenerMunicipioList();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet("[controller]/Details/{Muni_Codigo}")]
        public async Task<IActionResult> Details(string Muni_Codigo)
        {
            try
            {
                var model = new MunicipioViewModel();
                var list = await _MunicipioServicios.ObtenerMunicipio(Muni_Codigo);
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
        public async Task<IActionResult> Create(MunicipioViewModel item)
        {
            try
            {
                item.Muni_UsuarioCreacion = 2;
                item.Muni_FechaCreacion = DateTime.Now;
                var result = await _MunicipioServicios.CrearMunicipio(item);
                if (result.Success)
                {
                    return RedirectToAction("Index");
                }
                else
                {

                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }

        [HttpGet("[controller]/Edit/{Muni_Codigo}")]
        public async Task<IActionResult> Edit(string Muni_Codigo)
        {
            try
            {
                var model = await _MunicipioServicios.ObtenerMunicipio(Muni_Codigo);
                return Json(model.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("[controller]/Edit")]
        public async Task<IActionResult> Edit(MunicipioViewModel item)
        {
            try
            {
                item.Muni_UsuarioCreacion = 2;
                item.Muni_FechaCreacion = DateTime.Now;
                var result = await _MunicipioServicios.EditarMunicipio(item);
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

        [HttpPost("/[controller]/DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed([FromForm] string Muni_Codigo)
        {
            try
            {

                var result = await _MunicipioServicios.EliminarMunicipio(Muni_Codigo);
                if (result.Success)
                {
                    TempData["Exito"] = result.Message;
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Error"] = result.Message;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                return RedirectToAction(nameof(Index));
            }
        }
    }
}
