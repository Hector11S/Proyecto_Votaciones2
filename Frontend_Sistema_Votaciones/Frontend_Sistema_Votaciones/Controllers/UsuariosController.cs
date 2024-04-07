using Frontend_Sistema_Votaciones.Servicios;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sistema_Votaciones.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly UsuariosServicios _usuariosServicios;
        public UsuariosController(UsuariosServicios rolesServicios)
        {
            _usuariosServicios = rolesServicios;
        }
        public async Task<IActionResult> Index()
        {
            var model = new List<UsuariosViewModel>();
            var list = await _usuariosServicios.ObtenerUsuariosList();
            return View(list.Data);
        }
        [HttpGet("[controller]/Details/{Usua_Id}")]
        public async Task<IActionResult> Details(string Usua_Id)
        {
            try
            {
                var model = new UsuariosViewModel();
                var list = await _usuariosServicios.ObtenerUsuarios(Usua_Id);
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
        public async Task<IActionResult> Create(UsuariosViewModel item)
        {
            try
            {
                item.Usua_UsuarioCreacion = 4;
                item.Usua_FechaCreacion = DateTime.Now;
                var result = await _usuariosServicios.CrearUsuarios(item);
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

        [HttpGet("[controller]/Edit/{Usua_Id}")]
        public async Task<IActionResult> Edit(string Usua_Id)
        {
            try
            {
                var model = await _usuariosServicios.ObtenerUsuarios(Usua_Id);
                return Json(model.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("[controller]/Edit")]
        public async Task<IActionResult> Edit(UsuariosViewModel item)
        {
            try
            {
                item.Usua_UsuarioModifica = 4;
                item.Usua_FechaModifica = DateTime.Now;
                var result = await _usuariosServicios.EditarUsuarios(item);
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
                TempData["Error"] = "Error al editar el departamento";
                TempData["Item"] = JsonConvert.SerializeObject(item);
                return RedirectToAction("Index");
                throw;
            }
        }

        [HttpPost("/[controller]/DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed([FromForm] string Usua_Id)
        {
            try
            {
                var result = await _usuariosServicios.EliminarUsuarios(Usua_Id);
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
