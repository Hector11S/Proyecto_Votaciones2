using Frontend_Sistema_Votaciones.Models;
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
    public class PartidoController : Controller
    {
        private readonly AlcaldeServicios _alcaldeServicios;
        private readonly VotanteServicios _votanteServicios;
        private readonly DepartamentoServicios _departamentoServicios;
        private readonly MunicipioServicios _municipioServicios;
        private readonly PartidoServicios _partidoServicios;
        private readonly IWebHostEnvironment _hostingEnviroment;


        public PartidoController(
            AlcaldeServicios alcaldeServicios,
            VotanteServicios votanteServicios,
            DepartamentoServicios departamentoServicios,
            MunicipioServicios municipioServicios,
            PartidoServicios partidoServicios,
            IWebHostEnvironment hostingEnviroment)
        {
            _alcaldeServicios = alcaldeServicios;
            _votanteServicios = votanteServicios;
            _departamentoServicios = departamentoServicios;
            _municipioServicios = municipioServicios;
            _hostingEnviroment = hostingEnviroment;
        }

  
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<PartidoViewModel>();
                var list = await _partidoServicios.ObtenerPartidoList();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet("[controller]/Details/{Part_Id}")]
        public async Task<IActionResult> Details(string Part_Id)
        {
            try
            {
                var model = new PartidoViewModel();
                var list = await _partidoServicios.ObtenerPartido(Part_Id);
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
                var partidosList = await _partidoServicios.ObtenerPartidoList();
                ViewBag.Departamentos = departamentosList.Data;
                ViewBag.Partidos = partidosList.Data;
            }
            catch (Exception ex)
            {
                throw;
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PartidoViewModel item)
        {
            try
            {
                item.Part_UsuarioCreacion = 2;
                item.Part_FechaCreacion = DateTime.Now;
                var result = await _partidoServicios.CrearPartido(item);
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


        [HttpGet("[controller]/Edit/{Part_Id}")]
        public async Task<IActionResult> Edit(int Part_Id)
        {
            try
            {
                var model = await _partidoServicios.EliminarPartido(Part_Id);
                return Json(model.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("[controller]/Edit")]
        public async Task<IActionResult> Edit(PartidoViewModel item)
        {
            try
            {
                item.Part_UsuarioModifica = 2;
                item.Part_FechaModifica = DateTime.Now;
                var result = await _partidoServicios.EditarPartido(item);
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