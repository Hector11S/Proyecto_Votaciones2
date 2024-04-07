using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.Servicios;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class VotanteController : Controller
    {
        private readonly VotanteServicios _votanteServicios;
        private readonly DepartamentoServicios _departamentoServicios;
        private readonly MunicipioServicios _municipioServicios;
        private readonly IWebHostEnvironment _hostingEnviroment;


        public VotanteController(
            VotanteServicios votanteServicios,
            DepartamentoServicios departamentoServicios,
            MunicipioServicios municipioServicios,
            IWebHostEnvironment hostingEnviroment)
        {
            _votanteServicios = votanteServicios;
            _departamentoServicios = departamentoServicios;
            _municipioServicios = municipioServicios;
            _hostingEnviroment = hostingEnviroment;
        }

        [HttpGet("[controller]/ObtenerMunicipiosPorDept/{Dept_Codigo}")]
        public async Task<IActionResult> ObtenerMunicipios(string Dept_Codigo)
        {
            try
            {
                var response = await _municipioServicios.ObtenerMunicipiosList(Dept_Codigo);
                return Json(new { municipios = response.Data, message = response.Message });
            }
            catch (Exception ex)
            {
                return Json("Error de capa 8");
            }
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<VotanteViewModel>();
                var list = await _votanteServicios.ObtenerVotanteList();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet("[controller]/Details/{Vota_DNI}")]
        public async Task<IActionResult> Details(string Vota_DNI)
        {
            try
            {
                var model = new VotanteViewModel();
                var list = await _votanteServicios.ObtenerVotantePorDNI(Vota_DNI);
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        public async Task<IActionResult> Create()
        {
            try
            {
                var departamentosList = await _departamentoServicios.ObtenerDepartamentoList();
                ViewBag.Departamentos = departamentosList.Data;
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al cargar los departamentos";
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VotanteViewModel item)
        {
            try
            {
                item.Vota_UsuarioCreacion = 4;
                item.Vota_FechaCreacion = DateTime.Now;
                var result = await _votanteServicios.CrearVotante(item);
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
                TempData["Error"] = "Error al crear el registro de la persona.";
            }
            return View(item);
        }
        [HttpGet("[controller]/Edit/{Vota_DNI}")]
        public async Task<IActionResult> Edit(string Vota_DNI)
        {
            try
            {
                var model = await _votanteServicios.ObtenerVotantePorDNI(Vota_DNI);
                return View(model.Data);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al cargar la información de la persona";
            }
            return View();
        }

        [HttpPost("[controller]/Edit")]
        public async Task<IActionResult> Edit(VotanteViewModel item)
        {
            try
            {
                item.Vota_UsuarioModifica = 4;
                item.Vota_FechaModifica = DateTime.Now;
                var result = await _votanteServicios.EditarVotante(item);
                if (result.Success)
                {
                    TempData["Exito"] = result.Message;
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Advertencia"] = result.Message;
                    return View(item);
                }
            }
            catch (Exception ex)
            {
            }
            return View(item);
        }
        [HttpPost("/[controller]/DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed([FromForm] string Vota_DNI)
        {
            try
            {
                var result = await _votanteServicios.EliminarVotante(Vota_DNI);
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
                TempData["Error"] = "Error al cargar la información de la persona";
                return RedirectToAction("Index");
            }
        }
    }
}
