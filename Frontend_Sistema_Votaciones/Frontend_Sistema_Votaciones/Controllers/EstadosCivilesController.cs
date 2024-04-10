using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.Servicios;
using Frontend_Sistema_Votaciones.WebAPI;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class EstadosCivilesController : Controller
    {
        public EstadosCivilesServicios _estadosCivilesServicios;
        public EstadosCivilesController(EstadosCivilesServicios estadosCivilesServicios)
        {
            _estadosCivilesServicios = estadosCivilesServicios;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<EstadosCivilesViewModel>();
                var list = await _estadosCivilesServicios.ObtenerEstadosCivilesList();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet("[controller]/Details/{Esta_Id}")]
        public async Task<IActionResult> Details(int Esta_Id)
        {
            try
            {
                var model = new EstadosCivilesViewModel();
                var list = await _estadosCivilesServicios.ObtenerEstadosCiviles(Esta_Id);
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EstadosCivilesViewModel item)
        {
            try
            {
                item.Esta_UsuarioCreacion = 4;
                item.Esta_FechaCreacion = DateTime.Now;
                var result = await _estadosCivilesServicios.CrearEstadosCiviles(item);
                if (result.Success)
                {
                    TempData["AbrirModal"] = null;
                    TempData["Exito"] = result.Message;
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["AbrirModal"] = TiposDeModal.Nuevo;
                    TempData["Item"] = JsonConvert.SerializeObject(item);
                    TempData["Advertencia"] = result.Message;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al crear el estado civil.";
                TempData["Item"] = JsonConvert.SerializeObject(item);
                return RedirectToAction("Index");
            }
        }

        [HttpGet("[controller]/Edit/{Esta_Id}")]
        public async Task<IActionResult> Edit(int Esta_Id)
        {
            try
            {
                var model = await _estadosCivilesServicios.ObtenerEstadosCiviles(Esta_Id);
                return Json(model.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("[controller]/Edit")]
        public async Task<IActionResult> Edit(EstadosCivilesViewModel item)
        {
            try
            {
                item.Esta_UsuarioModifica = 4;
                item.Esta_FechaModifica = DateTime.Now;
                var result = await _estadosCivilesServicios.EditarEstadosCiviles(item);
                if (result.Success)
                {
                    TempData["AbrirModal"] = null;
                    TempData["Exito"] = result.Message;
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["AbrirModal"] = TiposDeModal.Editar;
                    TempData["Item"] = JsonConvert.SerializeObject(item);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al editar el estado civil";
                TempData["Item"] = JsonConvert.SerializeObject(item);
                return RedirectToAction("Index");
                throw;
            }
        }

        [HttpPost("/[controller]/DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed([FromForm] string Esta_Id)
        {
            try
            {
                var result = await _estadosCivilesServicios.EliminarEstadosCiviles(Esta_Id);
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
