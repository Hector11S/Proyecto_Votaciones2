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
        private readonly PresidenteServicios _PresidenteServicios;
        private readonly VotanteServicios _votanteServicios;
        private readonly DepartamentoServicios _departamentoServicios;
        private readonly MunicipioServicios _municipioServicios;
        private readonly PartidoServicios _partidoServicios;
        private readonly IWebHostEnvironment _hostingEnviroment;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public PresidenteController(
            PresidenteServicios presidenteServicios,
            PresidenteServicios PresidenteServicios,
            VotanteServicios votanteServicios,
            DepartamentoServicios departamentoServicios,
            MunicipioServicios municipioServicios,
            PartidoServicios partidoServicios,
            IWebHostEnvironment hostingEnviroment,
            IHttpContextAccessor httpContextAccessor)
        {
            _presidenteServicios = presidenteServicios;
            _PresidenteServicios = PresidenteServicios;
            _votanteServicios = votanteServicios;
            _departamentoServicios = departamentoServicios;
            _municipioServicios = municipioServicios;
            _partidoServicios = partidoServicios;
            _hostingEnviroment = hostingEnviroment;
            _httpContextAccessor = httpContextAccessor;
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
                    var nombreDeLaImagen = $"Presidente_{Pres_Id}.{extensionDeLaImagen}";
                    var rutaCarpeta = Path.Combine(_hostingEnviroment.WebRootPath, "assets", "presidentes");
                    var rutaImagen = Path.Combine(rutaCarpeta, nombreDeLaImagen);
                    using (var fileStream = new FileStream(rutaImagen, FileMode.Create))
                    {
                        await imagen.CopyToAsync(fileStream);
                    }
                    var result = await _PresidenteServicios.SubirImagen(rutaImagen);
                    if (System.IO.File.Exists(rutaImagen))
                    {
                        System.IO.File.Delete(rutaImagen);
                    }
                    return Json(new { message = result.Message, urlImagen = result.Data });
                }
                else
                {
                    return Json(new { message = "No se recibió ninguna imagen" });
                }
            }
            catch (Exception ex)
            {
                return Json(new { message = "Error al subir la imagen" });
            }
        }
        [HttpGet("[controller]/ObtenerVotantePorDNI/{Vota_DNI}")]
        public async Task<IActionResult> ObtenerVotantePorDNI(string Vota_DNI)
        {
            try
            {

                var reponseVotante = await _votanteServicios.ObtenerVotantePorDNI(Vota_DNI);
                VotanteViewModel votante = (VotanteViewModel)reponseVotante.Data;
                var responsePresidente = await _PresidenteServicios.ObtenerPresidente(Convert.ToString(votante.Vota_Id));
                if (responsePresidente.Success)
                {
                    return Json(new { message = "Ya existe un registro de este Presidente." });
                }
                else
                {
                    return Json(new { votante = reponseVotante.Data, message = reponseVotante.Message });
                }
            }
            catch (Exception ex)
            {
                return Json("Error al obtener la persona por el DNI");
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
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    TempData["Advertencia"] = "Debe iniciar sesión para acceder a esta pantalla.";
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet("[controller]/Details/{Alca_Id}")]
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
                TempData["Error"] = "Error al crear el Presidente.";
            }
            return View(item);
        }


        public async Task<IActionResult> Edit(string Pres_Id)
        {
            try
            {
                var departamentosList = await _departamentoServicios.ObtenerDepartamentoList();
                var partidosList = await _partidoServicios.ObtenerPartidoList();
                ViewBag.Departamentos = departamentosList.Data;
                ViewBag.Partidos = partidosList.Data;
                var response = await _presidenteServicios.ObtenerPresidente(Pres_Id);
                PresidenteViewModel presidenteViewModel = (PresidenteViewModel)response.Data;
                //var municipios = await _municipioServicios.ObtenerMunicipiosList(presidenteViewModel.Dept_Codigo);
                //ViewBag.Municipios = municipios.Data;
                return View(response.Data);
            }
            catch (Exception ex)
            {
                TempData["Error"] = $"Error al cargar informacion del Presidente {Pres_Id}.";
                return View();
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
                TempData["Error"] = "Error al editar el presidente.";
            }
            return RedirectToAction("Edit", "Presidente", new { Pres_Id = item.Pres_Id });
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
                TempData["Error"] = "Error al eliminar el Presidente";
                return RedirectToAction("Index");
            }
        }
    }
}
