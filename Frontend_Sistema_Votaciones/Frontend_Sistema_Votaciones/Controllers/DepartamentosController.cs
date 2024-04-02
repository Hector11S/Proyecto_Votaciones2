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
    public class DepartamentosController : Controller
    {
        public DepartamentosServicios _departamentosServicios;
        public DepartamentosController(DepartamentosServicios departamentosServicios)
        {
            _departamentosServicios = departamentosServicios;
        }
        // GET: DepartamentosController
        public async Task<IActionResult> Index()
        {
            try
            {
                //string token = HttpContext.User.FindFirst("Token").Value;
                var type = await _departamentosServicios.DepartamentosList();
                IEnumerable<DepartamentoViewModel> departamentos = (IEnumerable<DepartamentoViewModel>)type.Data;
                ViewBag.DepartamentosSelectList = new SelectList(departamentos, "Codigo", "Nombre");
                var model = new List<DepartamentoViewModel>();
                //var list = await _departamentosServicios.DepartamentosList(token);
                var list = await _departamentosServicios.DepartamentosList();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                RedirectToAction("Index", "Home");
            }
        }
        // GET: DepartamentosController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DepartamentosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DepartamentosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartamentosController/Create
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

        // GET: DepartamentosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DepartamentosController/Edit/5
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

        // GET: DepartamentosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DepartamentosController/Delete/5
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
