using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class VotosPorMesaController : Controller
    {
     
        public VotosPorMesaServicios _votosPorMesaServicios;
        private readonly AlcaldeServicios _alcaldeServicios;
        public VotosPorMesaController(AlcaldeServicios alcaldeServicios,VotosPorMesaServicios VotosPorMesaServicios)
        {
            _alcaldeServicios = alcaldeServicios;
            _votosPorMesaServicios = VotosPorMesaServicios;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<VotosPorMesasViewModel>();
                var list = await _votosPorMesaServicios.VotosPorMesaList();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AlcaldesVotar(VotosPorMesasViewModel item)
        {
            try
            {
                item.MePS_Id = 1;
                item.VoMe_EsPresidente = false;
                var result = await _votosPorMesaServicios.CrearVotosPorMesa(item);
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


        [HttpGet("[controller]/Details/{VoMe_Id}")]
        public async Task<IActionResult> Details(int VoMe_Id)
        {
            try
            {
                var model = new VotosPorMesasViewModel();
                var list = await _votosPorMesaServicios.ObtenerVotosPorMesa(VoMe_Id);
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
        
                var alcaldes = await _alcaldeServicios.ObtenerAlcaldeList();
                ViewBag.Alcaldes = alcaldes.Data;

          
                var model = new VotosPorMesasViewModel();

                return View(model);
            }
            catch (Exception ex)
            {
  
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VotosPorMesasViewModel item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                
                    item.MePS_Id = 1; 

       
                    var result = await _votosPorMesaServicios.CrearVotosPorMesa(item);

                    if (result.Success)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
         
                        return RedirectToAction("Index");
                    }
                }
                else
                {
              
                    var alcaldes = await _alcaldeServicios.ObtenerAlcaldeList();
                    ViewBag.Alcaldes = alcaldes.Data;

                    return View(item);
                }
            }
            catch (Exception ex)
            {
     
                return RedirectToAction("Index");
            }
        }



        [HttpGet("[controller]/Edit/{VoMe_Id}")]
        public async Task<IActionResult> Edit(int VoMe_Id)
        {
            try
            {
                var model = await _votosPorMesaServicios.ObtenerVotosPorMesa(VoMe_Id);
                return Json(model.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("[controller]/Edit")]
        public async Task<IActionResult> Edit(VotosPorMesasViewModel item)
        {
            try
            {

                var result = await _votosPorMesaServicios.EditarVotosPorMesa(item);
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
