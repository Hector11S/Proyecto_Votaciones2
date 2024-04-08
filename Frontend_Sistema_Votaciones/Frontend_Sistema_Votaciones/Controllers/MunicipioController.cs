using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class MunicipioController : Controller
    {
        public MunicipioServicios _municipioServicios;
        public DepartamentoServicios _departamentoServicios;
        public MunicipioController(MunicipioServicios municipioServicios, DepartamentoServicios departamentoServicios)
        {
            _municipioServicios = municipioServicios;
            _departamentoServicios = departamentoServicios;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<MunicipioViewModel>();
                var list = await _municipioServicios.ObtenerMunicipioList();
                var departamentosResult = await _departamentoServicios.ObtenerDepartamentoList();
                ViewBag.Departamentos = departamentosResult.Data;
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
                var list = await _municipioServicios.ObtenerMunicipio(Muni_Codigo);
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
                item.Muni_Codigo = item.Dept_Codigo + item.Muni_Codigo;
                item.Muni_UsuarioCreacion = 4;
                item.Muni_FechaCreacion = DateTime.Now;
                var result = await _municipioServicios.CrearMunicipio(item);
                if (result.Success)
                {
                    TempData["AbrirModal"] = null;
                    TempData["Exito"] = result.Message;
                    return RedirectToAction("Index");
                }
                else
                {
                    item.Muni_Codigo = item.Muni_Codigo.Substring(2,2);
                    TempData["AbrirModal"] = TiposDeModal.Nuevo;
                    TempData["Item"] = JsonConvert.SerializeObject(item);
                    TempData["Advertencia"] = result.Message;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                item.Muni_Codigo = item.Muni_Codigo.Substring(2,2);
                TempData["Error"] = "Error al crear el municipio.";
                TempData["Item"] = JsonConvert.SerializeObject(item);
                return RedirectToAction("Index");
            }
        }

        [HttpGet("[controller]/Edit/{Muni_Codigo}")]
        public async Task<IActionResult> Edit(string Muni_Codigo)
        {
            try
            {
                var model = await _municipioServicios.ObtenerMunicipio(Muni_Codigo);
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
                item.Muni_UsuarioModifica = 4;
                item.Muni_FechaModifica = DateTime.Now;
                var result = await _municipioServicios.EditarMunicipio(item);
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
                TempData["Error"] = "Error al editar el municipio";
                TempData["Item"] = JsonConvert.SerializeObject(item);
                return RedirectToAction("Index");
                throw;
            }
        }

        [HttpPost("/[controller]/DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed([FromForm] string Muni_Codigo)
        {
            try
            {

                var result = await _municipioServicios.EliminarMunicipio(Muni_Codigo);
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
                TempData["Error"] = "Error al eliminar el departamento";
                return RedirectToAction("Index");
            }
        }
    }
}
