using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend_Sistema_Votaciones.Servicios;
using Frontend_Sistema_Votaciones.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class DepartamentoController : Controller
    {
        public DepartamentoServicios _departamentoServicios;
        public DepartamentoController(DepartamentoServicios departamentoServicios)
        {
            _departamentoServicios = departamentoServicios;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<DepartamentoViewModel>();
                var list = await _departamentoServicios.ObtenerDepartamentoList();
                return View(list.Data);
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
                item.Dept_UsuarioCreacion = 2;
                item.Dept_FechaCreacion = DateTime.Now;
                var result = await _departamentoServicios.EditarDepartamento(item);
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
        public async Task<IActionResult> DeleteConfirmed([FromForm] string Dept_Codigo)
        {
            try
            {
           
                var result = await _departamentoServicios.EliminarDepartamento(Dept_Codigo);
                if (result.Success)
                {
              
                    return RedirectToAction(nameof(Index));
                }
                else
                {
         
                    return View("Error");
                }
            }
            catch (Exception ex)
            {
        
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
