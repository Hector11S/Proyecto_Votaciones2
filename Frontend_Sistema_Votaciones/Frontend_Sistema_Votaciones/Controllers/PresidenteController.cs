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
    public class PresidenteController : Controller
    {
        private readonly PresidenteServicios _presidenteServicios;
        private readonly AlcaldeServicios _alcaldeServicios;
        private readonly VotanteServicios _votanteServicios;
        private readonly DepartamentoServicios _departamentoServicios;
        private readonly MunicipioServicios _municipioServicios;
        private readonly PartidoServicios _partidoServicios;
        private readonly IWebHostEnvironment _hostingEnviroment;


        public PresidenteController(
            PresidenteServicios presidenteServicios,
            AlcaldeServicios alcaldeServicios,
            VotanteServicios votanteServicios,
            DepartamentoServicios departamentoServicios,
            MunicipioServicios municipioServicios,
            PartidoServicios partidoServicios,
            IWebHostEnvironment hostingEnviroment)
        {
            _presidenteServicios = presidenteServicios;
            _alcaldeServicios = alcaldeServicios;
            _votanteServicios = votanteServicios;
            _departamentoServicios = departamentoServicios;
            _municipioServicios = municipioServicios;
            _partidoServicios = partidoServicios;
            _hostingEnviroment = hostingEnviroment;
        }

        [HttpPost]
        public async Task<IActionResult> SubirImagen(IFormCollection formData, IFormFile imagen)
        {
            try
            {
                if (imagen != null && imagen.Length > 0)
                {
                    var Pres_Id = formData["Pres_Id"];
                    var extensionDeLaImagen = imagen.FileName.Split('.')[1];
                    var nombreDeLaImagen = $"Alcalde_{Pres_Id}.{extensionDeLaImagen}";
                    var rutaCarpeta = Path.Combine(_hostingEnviroment.WebRootPath, "assets", "alcaldes");
                    var rutaImagen = Path.Combine(rutaCarpeta, nombreDeLaImagen);
                    using (var fileStream = new FileStream(rutaImagen, FileMode.Create))
                    {
                        await imagen.CopyToAsync(fileStream);
                    }
                    var result = await _presidenteServicios.SubirImagen(rutaImagen);
                    return Json(new { message = result.Message, urlImagen = result.Data });
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
                var reponse = await _votanteServicios.ObtenerVotantePorDNI(Vota_DNI);
                return Json(new { votante = reponse.Data, message = reponse.Message });
            }
            catch (Exception ex)
            {
                return Json("Error de capa 8");
            }
        }
        //[HttpGet("[controller]/ObtenerMunicipiosPorDept/{Dept_Codigo}")]
        //public async Task<IActionResult> ObtenerMunicipios(string Dept_Codigo)
        //{
        //    try
        //    {
        //        var response = await _municipioServicios.ObtenerMunicipiosList(Dept_Codigo);
        //        return Json(new { municipios = response.Data, message = response.Message });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { message = "Error al cargar los municipios" });
        //    }
        //}
        public async Task<IActionResult> Index()
        {
            try
            {
                var rol = HttpContext.Session.GetInt32("Rol_Id");
                if (rol != null)
                {
                    bool autorizado = Autorizacion.Autorizar(Convert.ToInt32(rol), ControllerContext.ActionDescriptor.ControllerName);
                    if (autorizado)
                    {
                        var model = new List<PresidenteViewModel>();
                        var list = await _presidenteServicios.ObtenerPresidenteList();
                        return View(list.Data);
                    }
                    else
                    {
                        TempData["Advertencia"] = "No está autorizado para acceder a esta pantalla.";
                    }
                }
                else
                {
                    TempData["Advertencia"] = "Debe iniciar sesión para acceder a esta pantalla.";
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al cargar el listado.";
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("[controller]/Details/{Pres_Id}")]
        public async Task<IActionResult> Details(string Pres_Id)
        {
            try
            {
                var model = new PresidenteViewModel();
                var list = await _presidenteServicios.ObtenerPresidente(Pres_Id);
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
                //var departamentosList = await _departamentoServicios.ObtenerDepartamentoList();
                var partidosList = await _partidoServicios.ObtenerPartidoList();
                //ViewBag.Departamentos = departamentosList.Data;
                ViewBag.Partidos = partidosList.Data;
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al cargar departamentos y partidos.";
                throw;
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PresidenteViewModel item)
        {
            try
            {
                item.Pres_UsuarioCreacion = 4;
                item.Pres_FechaCreacion = DateTime.Now;
                var result = await _presidenteServicios.CrearPresidente(item);
                if (result.Success)
                {
                    TempData["AbrirModal"] = null;
                    TempData["Exito"] = result.Message;
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Advertencia"] = result.Message;
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al crear el alcalde.";
            }
            return View(item);
        }


        [HttpGet("[controller]/Edit/{Dept_Codigo}")]
        public async Task<IActionResult> Edit(string Pres_Id)
        {
            try
            {
                var model = await _presidenteServicios.ObtenerPresidente(Pres_Id);
                return Json(model.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("[controller]/Edit")]
        public async Task<IActionResult> Edit(PresidenteViewModel item)
        {
            try
            {
                item.Pres_UsuarioModifica = 4;
                item.Pres_FechaModifica = DateTime.Now;
                var result = await _presidenteServicios.EditarPresidente(item);
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
        public async Task<IActionResult> DeleteConfirmed([FromForm] int Pres_Id)
        {
            try
            {
                var result = await _presidenteServicios.EliminarPresidente(Pres_Id);
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
                TempData["Error"] = "Error al eliminar el alcalde";
                return RedirectToAction("Index");
            }
        }
    }
}
