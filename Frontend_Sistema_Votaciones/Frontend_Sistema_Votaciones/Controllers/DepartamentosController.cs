using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend_Sistema_Votaciones.Servicios;
using Frontend_Sistema_Votaciones.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class DepartamentosController : Controller
    {
        private readonly DepartamentoServicios _departamentoServicios;

        public DepartamentosController(DepartamentoServicios departamentoServicios)
        {
            _departamentoServicios = departamentoServicios;
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
                        var model = new List<DepartamentoViewModel>();
                        var list = await _departamentoServicios.ObtenerDepartamentoList();
                        return View(list.Data);
                    }
                    else
                    {
                        TempData["Advertencia"] = "No está autorizado para acceder a esta pantalla.";
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    TempData["Advertencia"] = "Debe iniciar sesión para acceder a esta pantalla.";
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet("[controller]/Details/{Dept_Codigo}")]
        public async Task<IActionResult> Details(string Dept_Codigo)
        {
            try
            {
                var model = new DepartamentoViewModel();
                var list = await _departamentoServicios.ObtenerDepartamento(Dept_Codigo);
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
        public async Task<IActionResult> Create(DepartamentoViewModel item)
        {
            try
            {
                item.Dept_UsuarioCreacion = 4;
                item.Dept_FechaCreacion = DateTime.Now;
                var result = await _departamentoServicios.CrearDepartamento(item);
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

        [HttpGet("[controller]/Edit/{Dept_Codigo}")]
        public async Task<IActionResult> Edit(string Dept_Codigo)
        {
            try
            {
                var model = await _departamentoServicios.ObtenerDepartamento(Dept_Codigo);
                return Json(model.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("[controller]/Edit")]
        public async Task<IActionResult> Edit(DepartamentoViewModel item)
        {
            try
            {
                item.Dept_UsuarioModifica = 4;
                item.Dept_FechaModifica = DateTime.Now;
                var result = await _departamentoServicios.EditarDepartamento(item);
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
        public async Task<IActionResult> DeleteConfirmed([FromForm] string Dept_Codigo)
        {
            try
            {
                var result = await _departamentoServicios.EliminarDepartamento(Dept_Codigo);
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
                TempData["Error"] = "Error al eliminar el departamento";
                return RedirectToAction("Index");
            }
        }
    }
}
