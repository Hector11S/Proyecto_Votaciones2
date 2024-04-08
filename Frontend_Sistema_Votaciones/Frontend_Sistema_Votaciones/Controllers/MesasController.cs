using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.Servicios;
using Frontend_Sistema_Votaciones.WebAPI;
using Microsoft.AspNetCore.Mvc;
using Sistema_Votaciones.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class MesasController : Controller
    {
        public MesasServicios _mesasServicios;
        public MesasController(MesasServicios mesasServicios)
        {
            _mesasServicios = mesasServicios;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<MesasViewModel>();
                var list = await _mesasServicios.ObtenerMesasList();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet("[controller]/Details/{Mesa_Id}")]
        public async Task<IActionResult> Details(int Mesa_Id)
        {
            try
            {
                var model = new MesasViewModel();
                var list = await _mesasServicios.ObtenerMesas(Mesa_Id);
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
        public async Task<IActionResult> Create(MesasViewModel item)
        {
            try
            {
                item.Mesa_UsuarioCreacion = 4;
                item.Mesa_FechaCreacion = DateTime.Now;
                var result = await _mesasServicios.CrearMesas(item);
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

        [HttpGet("[controller]/Edit/{Mesa_Id}")]
        public async Task<IActionResult> Edit(int Mesa_Id)
        {
            try
            {
                var model = await _mesasServicios.ObtenerMesas(Mesa_Id);
                return Json(model.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("[controller]/Edit")]
        public async Task<IActionResult> Edit(MesasViewModel item)
        {
            try
            {
                item.Mesa_UsuarioModifica = 4;
                item.Mesa_FechaModifica = DateTime.Now;
                var result = await _mesasServicios.EditarMesas(item);
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
        public async Task<IActionResult> DeleteConfirmed([FromForm] string Mesa_Id)
        {
            try
            {
                var result = await _mesasServicios.EliminarMesas(Mesa_Id);
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
