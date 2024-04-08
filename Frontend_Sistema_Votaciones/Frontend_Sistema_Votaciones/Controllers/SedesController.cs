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
    public class SedesController : Controller
    {
        public SedesServicios _sedesServicios;
        public SedesController(SedesServicios sedesServicios)
        {
            _sedesServicios = sedesServicios;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<SedesViewModel>();
                var list = await _sedesServicios.ObtenerSedesList();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet("[controller]/Details/{Sede_Id}")]
        public async Task<IActionResult> Details(int Sede_Id)
        {
            try
            {
                var model = new SedesViewModel();
                var list = await _sedesServicios.ObtenerSedes(Sede_Id);
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
        public async Task<IActionResult> Create(SedesViewModel item)
        {
            try
            {
                item.Sede_UsuarioCreacion = 4;
                item.Sede_FechaCreacion = DateTime.Now;
                var result = await _sedesServicios.CrearSedes(item);
                if (result.Success)
                {
                    TempData["AbrirModal"] = null;
                    TempData["Exito"] = result.Message;
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["AbrirModal"] = TiposDeModal.Nuevo;
                    //TempData["Item"] = JsonConvert.SerializeObject(item);
                    TempData["Advertencia"] = result.Message;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al crear el departamento.";
                //TempData["Item"] = JsonConvert.SerializeObject(item);
                return RedirectToAction("Index");
            }
        }

        [HttpGet("[controller]/Edit/{Sede_Id}")]
        public async Task<IActionResult> Edit(int Sede_Id)
        {
            try
            {
                var model = await _sedesServicios.ObtenerSedes(Sede_Id);
                return Json(model.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("[controller]/Edit")]
        public async Task<IActionResult> Edit(SedesViewModel item)
        {
            try
            {
                item.Sede_UsuarioModifica = 4;
                item.Sede_FechaModifica = DateTime.Now;
                var result = await _sedesServicios.EditarSedes(item);
                if (result.Success)
                {
                    TempData["AbrirModal"] = null;
                    TempData["Exito"] = result.Message;
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["AbrirModal"] = TiposDeModal.Editar;
                    //TempData["Item"] = JsonConvert.SerializeObject(item);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al editar el departamento";
                //TempData["Item"] = JsonConvert.SerializeObject(item);
                return RedirectToAction("Index");
                throw;
            }
        }

        [HttpPost("/[controller]/DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed([FromForm] string Sede_Id)
        {
            try
            {
                var result = await _sedesServicios.EliminarSedes(Sede_Id);
                if (result.Success)
                {
                    TempData["Exito"] = result.Message;
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Advertencia"] = result.Message;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error dentro del código de la aplicación. Por favor contacte a un administrador del sistema";
                return RedirectToAction("Index");
            }
        }
    }
}
