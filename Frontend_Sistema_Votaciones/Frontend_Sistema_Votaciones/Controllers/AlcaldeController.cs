﻿using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class AlcaldeController : Controller
    {
        private readonly AlcaldeServicios _alcaldeServicios;
        private readonly VotanteServicios _votanteServicios;
        private readonly DepartamentoServicios _departamentoServicios;
        private readonly IWebHostEnvironment _hostingEnviroment;


        public AlcaldeController(AlcaldeServicios alcaldeServicios, VotanteServicios votanteServicios, DepartamentoServicios departamentoServicios, IWebHostEnvironment hostingEnviroment)
        {
            _alcaldeServicios = alcaldeServicios;
            _votanteServicios = votanteServicios;
            _departamentoServicios = departamentoServicios;
            _hostingEnviroment = hostingEnviroment;
        }
        [HttpPost]
        public async Task<IActionResult> SubirImagen(IFormCollection formData, IFormFile imagen)
        {
            try
            {
                if (imagen != null && imagen.Length > 0)
                {
                    var Alca_Id = formData["Alca_Id"];
                    var nombreDeLaImagen = $"Alcalde_{Alca_Id}.jpg";
                    var rutaCarpeta = Path.Combine(_hostingEnviroment.WebRootPath, "assets", "alcaldes");
                    var rutaImagen = Path.Combine(rutaCarpeta, nombreDeLaImagen);
                    using (var fileStream = new FileStream(rutaImagen,FileMode.Create))
                    {
                        await imagen.CopyToAsync(fileStream);
                    }
                    var result = await _alcaldeServicios.SubirImagen(rutaImagen);
                    return Json( new { message= result.Message, urlImagen= result.Data });
                }
                else
                {
                    return Json("No se recibió ninguna imagen");
                }
            }
            catch (Exception ex)
            {
                return Json("Error de capa 8");
            }
        }
        [HttpGet("[controller]/ObtenerVotantePorDNI/{Vota_DNI}")]
        public async Task<IActionResult> ObtenerVotantePorDNI(string Vota_DNI)
        {
            try
            {
                var model = await _votanteServicios.ObtenerVotantePorDNI(Vota_DNI);
                return Json(model.Data);
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
                var model = new List<AlcaldeViewModel>();
                var list = await _alcaldeServicios.ObtenerAlcaldeList();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet("[controller]/Details/{Alca_Id}")]
        public async Task<IActionResult> Details(string Alca_Id)
        {
            try
            {
                var model = new AlcaldeViewModel();
                var list = await _alcaldeServicios.ObtenerAlcalde(Alca_Id);
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
                throw;
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AlcaldeViewModel item)
        {
            try
            {
                item.Alca_UsuarioCreacion = 2;
                item.Alca_FechaCreacion = DateTime.Now;
                var result = await _alcaldeServicios.CrearAlcalde(item);
                if (result.Success)
                {
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                //return View(item);
            }
            return View(item);
        }
        [HttpGet("[controller]/Edit/{Dept_Codigo}")]
        public async Task<IActionResult> Edit(string Alca_Id)
        {
            try
            {
                var model = await _alcaldeServicios.ObtenerAlcalde(Alca_Id);
                return Json(model.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("[controller]/Edit")]
        public async Task<IActionResult> Edit(AlcaldeViewModel item)
        {
            try
            {
                item.Alca_UsuarioCreacion = 2;
                item.Alca_FechaCreacion = DateTime.Now;
                var result = await _alcaldeServicios.EditarAlcalde(item);
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
    }
}