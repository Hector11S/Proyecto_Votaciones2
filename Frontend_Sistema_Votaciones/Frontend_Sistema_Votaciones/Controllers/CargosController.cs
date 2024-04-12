using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class CargosController : Controller
    {
        public CargoServicios _cargosServicios;
        public CargosController(CargoServicios cargosServicios)
        {
            _cargosServicios = cargosServicios;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var rol = HttpContext.Session.GetInt32("Rol_Id");
                if (rol != null)
                {
                    bool autorizado = Autorizacion.Autorizar(Convert.ToInt32(rol), ControllerContext.ActionDescriptor.ControllerName);
                    if (autorizado)
                    {
                        var model = new List<CargoViewModel>();
                        var list = await _cargosServicios.ObtenerCargoList();
                        return View(list.Data);
                    }
                    else
                    {
                        TempData["Advertencia"] = "No está autorizado para acceder a esta pantalla.";
                    }
                }
                else
                {
                    TempData["Advertencia"] = "Debe iniciar sesión para acceder a esta pantalla.";
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al cargar el listado.";
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("[controller]/Details/{Carg_Id}")]
        public async Task<IActionResult> Details(int Carg_Id)
        {
            try
            {
                var model = new CargoViewModel();
                var list = await _cargosServicios.ObtenerCargo(Carg_Id);
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
        public async Task<IActionResult> Create(CargoViewModel item)
        {
            try
            {
                if (item.Carg_Descripcion == null)
                {
                    TempData["AbrirModal"] = TiposDeModal.Nuevo;
                    TempData["Item"] = JsonConvert.SerializeObject(item);
                    TempData["Advertencia"] = "Rellene Todos Los Campos";
                    return RedirectToAction("Index");
                }

                item.Carg_UsuarioCreacion = 4;
                item.Carg_FechaCreacion = DateTime.Now;
                var result = await _cargosServicios.CrearCargo(item);
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
                TempData["Error"] = "Error al crear el departamento.";
                TempData["Item"] = JsonConvert.SerializeObject(item);
                return RedirectToAction("Index");
            }
        }

        [HttpGet("[controller]/Edit/{Carg_Id}")]
        public async Task<IActionResult> Edit(int Carg_Id)
        {
            try
            {
                var model = await _cargosServicios.ObtenerCargo(Carg_Id);
                return Json(model.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("[controller]/Edit")]
        public async Task<IActionResult> Edit(CargoViewModel item)
        {
            try
            {
                if (item.Carg_Descripcion == null)
                {
                    TempData["AbrirModal"] = TiposDeModal.Editar;
                    TempData["Item"] = JsonConvert.SerializeObject(item);
                    TempData["Advertencia"] = "Rellene Todos Los Campos";
                    return RedirectToAction("Index");
                }
                item.Carg_UsuarioModifica = 4;
                item.Carg_FechaModifica = DateTime.Now;
                var result = await _cargosServicios.EditarCargo(item);
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
                    TempData["Advertencia"] = result.Message;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al editar el departamento";
                TempData["Item"] = JsonConvert.SerializeObject(item);
                return RedirectToAction("Index");
                throw;
            }
        }

        [HttpPost("/[controller]/DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed([FromForm] string Carg_Id)
        {
            try
            {
                var result = await _cargosServicios.EliminarCargo(Carg_Id);
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
                TempData["Error"] = $"Error al eliminar el cargo {Carg_Id}";
                return RedirectToAction("Index");
            }
        }
    }
}
