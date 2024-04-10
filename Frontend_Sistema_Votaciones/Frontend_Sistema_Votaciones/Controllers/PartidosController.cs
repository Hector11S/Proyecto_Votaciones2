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
    public class PartidosController : Controller
    {
        private readonly PartidoServicios _partidoServicios;
        private readonly IWebHostEnvironment _hostingEnviroment;


        public PartidosController(
            PartidoServicios partidoServicios,
            IWebHostEnvironment hostingEnviroment)
        {
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
                    var Part_Id = formData["Part_Id"];
                    var extensionDeLaImagen = imagen.FileName.Split('.')[1];
                    var nombreDeLaImagen = $"Usuario_{Part_Id}.{extensionDeLaImagen}";
                    var rutaCarpeta = Path.Combine(_hostingEnviroment.WebRootPath, "assets", "usuarios");
                    var rutaImagen = Path.Combine(rutaCarpeta, nombreDeLaImagen);
                    using (var fileStream = new FileStream(rutaImagen, FileMode.Create))
                    {
                        await imagen.CopyToAsync(fileStream);
                    }
                    var result = await _partidoServicios.SubirImagen(rutaImagen);
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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PartidoViewModel item)
        {
            try
            {
                if (item.Part_Descripcion == null)
                {
                    TempData["Advertencia"] = "Por favor ingrese el nombre del partido.";
                    return View(item);
                }
                if (item.Part_Color == null)
                {
                    TempData["Advertencia"] = "Por favor elija un color para el partido.";
                    return View(item);
                }
                if (item.Part_Imagen == null)
                {
                    TempData["Advertencia"] = "Por favor seleccione una imagen para el partido.";
                    return View(item);
                }
                item.Part_UsuarioCreacion = 4;
                item.Part_FechaCreacion = DateTime.Now;
                var result = await _partidoServicios.CrearPartido(item);
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
                TempData["Error"] = "Error al crear el partido.";
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
                item.Part_UsuarioModifica = 4;
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