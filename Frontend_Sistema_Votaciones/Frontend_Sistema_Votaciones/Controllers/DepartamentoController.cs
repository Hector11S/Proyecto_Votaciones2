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
        // GET: DepartamentosController
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

        // GET: Departamento/Details/5
        [HttpGet("Departamento/Details/{Dept_Codigo}")]
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

        // GET: DepartamentosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartamentosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DepartamentoViewModel item)
        {
            try
            {
                item.Dept_UsuarioCreacion = 2;
                item.Dept_FechaCreacion = DateTime.Now;
                var list = await _departamentoServicios.CrearDepartamento(item);
                return RedirectToAction("Index");
                //return View(new List<DepartamentoViewModel> { (DepartamentoViewModel)list.Data } );
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }

        // GET: Departamento/Edit/5
        [HttpGet("Departamento/Edit/{Dept_Codigo}")]
        public async Task<IActionResult> Edit(string Dept_Codigo)
        {
            try
            {
                var model = await _departamentoServicios.ObtenerDepartamento(Dept_Codigo);
                return View(model.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
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

        //GET: DepartamentosController/Delete/5
        //public ActionResult Delete()
        //{
        //    try
        //    {
        //        return View();
        //    }
        //    catch (Exception ex)
        //    {

        //        return RedirectToAction("Index");
        //    }
        //}


        // POST: DepartamentosController/DeleteConfirmed
        [HttpPost("/Departamento/DeleteConfirmed")]
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
