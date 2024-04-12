using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class VotosPorMesaController : Controller
    {
        private readonly PresidenteServicios _presidenteServicios;
        public VotosPorMesaServicios _votosPorMesaServicios;
        private readonly AlcaldeServicios _alcaldeServicios;
        private readonly VotanteServicios _votanteServicios;
        private readonly PartidoServicios _partidoServicios;
        private readonly MunicipioServicios _municipioServicios;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public VotosPorMesaController(MunicipioServicios municipioServicios, 
            PresidenteServicios presidenteServicios, 
            PartidoServicios partidoServicios,
            VotanteServicios votanteServicios, 
            AlcaldeServicios alcaldeServicios,
            VotosPorMesaServicios VotosPorMesaServicios,
            IHttpContextAccessor httpContextAccessor)
        {
            _presidenteServicios = presidenteServicios;
            _alcaldeServicios = alcaldeServicios;
            _votosPorMesaServicios = VotosPorMesaServicios;
            _votanteServicios = votanteServicios;
            _partidoServicios = partidoServicios;
            _municipioServicios = municipioServicios;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                string Muni_Codigo = HttpContext.Session.GetString("Muni_Codigo") ?? "0501";
                ViewBag.Muni_Codigo = Muni_Codigo;
                var model = new List<VotosPorMesasViewModel>();

        
                var listAlcaldes = await _votosPorMesaServicios.VotosPorMesaListAlcaldes(Muni_Codigo);
                ViewBag.ListaVotosAlcaldes = listAlcaldes.Data;

           
                var votante = await _votanteServicios.ObtenerVotanteList();
                var listPresidentes = await _votosPorMesaServicios.VotosPorMesaListPresidentes();
                var municipio = await _municipioServicios.ObtenerMunicipioList();

                var votosMesa = await _votosPorMesaServicios.VotosPorMesaList();

                ViewBag.votosPorMesa = votosMesa.Data;


                ViewBag.ListaVotosPresidentes = listPresidentes.Data;
                ViewBag.Municipios = municipio.Data;
                ViewBag.Votante = votante.Data;

                return View(model);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }


        [HttpGet]
        public async Task<IActionResult> VerAlclades(string muniCodigo)
        {
            try
            {
             
                HttpContext.Session.SetString("Muni_Codigo", muniCodigo);

                ViewBag.Muni_Codigo = muniCodigo;

                var model = new List<VotosPorMesasViewModel>();

                var listAlcaldes = await _votosPorMesaServicios.VotosPorMesaListAlcaldes(muniCodigo);

                return Json(new { listAlcaldes = listAlcaldes.Data });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpPost]
        public IActionResult ActualizarCodigoMunicipio(string muniCodigo) 
        {
            try
            {
                HttpContext.Session.SetString("Muni_Codigo", muniCodigo);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
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
                    TempData["Exito"] = "Gracias por votar";
                    return RedirectToAction("Index", "Home");
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

        public async Task<IActionResult> Create(string Vota_DNI)
        {
            try
            {
                var alcaldes = await _alcaldeServicios.ObtenerAlcaldeListar(Vota_DNI);
                var votante = await _votanteServicios.ObtenerVotanteList();
                var partido = await _partidoServicios.ObtenerPartidoList();

                ViewBag.Alcaldes = alcaldes.Data;
                ViewBag.Votante = votante.Data;
                ViewBag.Partidos = partido.Data;

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
                        TempData["Exito"] = "El voto por el Alcalde se ha creado correctamente.";
                        return RedirectToAction("CreatePresi", "VotosPorMesa");
                    }
                    else
                    {
                        TempData["Advertencia"] = "No se pudo crear el voto.";
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
                TempData["Error"] = "Error al procesar la solicitud.";
                return RedirectToAction("Index");
            }
        }

        public async Task<IActionResult> CreatePresi()
        {
            try
            {

                var presidente = await _presidenteServicios.ObtenerPresidenteList();
                var alcaldes = await _alcaldeServicios.ObtenerAlcaldeList();
                var votante = await _votanteServicios.ObtenerVotanteList();
                var partido = await _partidoServicios.ObtenerPartidoList();

                ViewBag.Alcaldes = alcaldes.Data;
                ViewBag.Votante = votante.Data;
                ViewBag.Partidos = partido.Data;
                ViewBag.Presidente = presidente.Data;

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
        public async Task<IActionResult> CreatePresi(VotosPorMesasViewModel item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    item.MePS_Id = 1;
                    item.VoMe_EsPresidente = true;

                

                    var result = await _votosPorMesaServicios.CrearVotosPorMesa(item);

                    if (result.Success)
                    {
                        TempData["Exito"] = "El voto por el presidente se ha creado correctamente.";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["Advertencia"] = "No se pudo crear el voto por el presidente.";
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
                TempData["Error"] = "Error al procesar la solicitud.";
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

        [HttpGet]
        public async Task<IActionResult> VotosPorMesaListPorMunicipio(string Muni_Codigo)
        {
            try
            {
                var result = await _municipioServicios.ObtenerMunicipiosList(Muni_Codigo);
                return Json(result.Data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        public async Task<IActionResult> ObtenerDatosAlcaldePorMunicipio(string Muni_Codigo)
        {
            try
            {
                var result = await _votosPorMesaServicios.VotosPorMesaListAlcaldes(Muni_Codigo);
                return Json(result.Data); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
