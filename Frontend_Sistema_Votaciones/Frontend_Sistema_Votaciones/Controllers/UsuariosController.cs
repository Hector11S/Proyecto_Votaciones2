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

    public class UsuariosController : Controller
    {
        private readonly RolesServicios _rolesServicios;
        private readonly UsuariosServicios _usuariosServicios;
        private readonly EmpleadoServicios _empleadoServicios;
        private readonly VotanteServicios _votanteServicios;
        private readonly IWebHostEnvironment _hostingEnviroment;

        public UsuariosController(UsuariosServicios usuariosServicios,
            VotanteServicios votanteServicios,
            EmpleadoServicios empleadoServicios,
            RolesServicios rolesServicios,
            IWebHostEnvironment hostingEnviroment)
        {
            _usuariosServicios = usuariosServicios;
            _rolesServicios = rolesServicios;
            _hostingEnviroment = hostingEnviroment;
            _empleadoServicios = empleadoServicios;
            _votanteServicios = votanteServicios;
        }
        [HttpPost]
        public async Task<IActionResult> SubirImagen(IFormCollection formData, IFormFile imagen)
        {
            try
            {
                if (imagen != null && imagen.Length > 0)
                {
                    var Usua_Id = formData["Usua_Id"];
                    var extensionDeLaImagen = imagen.FileName.Split('.')[1];
                    var nombreDeLaImagen = $"Usuario_{Usua_Id}.{extensionDeLaImagen}";
                    var rutaCarpeta = Path.Combine(_hostingEnviroment.WebRootPath, "assets", "usuarios");
                    var rutaImagen = Path.Combine(rutaCarpeta, nombreDeLaImagen);
                    using (var fileStream = new FileStream(rutaImagen, FileMode.Create))
                    {
                        await imagen.CopyToAsync(fileStream);
                    }
                    var result = await _usuariosServicios.SubirImagen(rutaImagen);
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
                var reponseEmpleado = await _empleadoServicios.ObtenerEmpleado(votante.Vota_Id);
                if (reponseEmpleado.Success)
                {
                    EmpleadoViewModel empleado = (EmpleadoViewModel)reponseEmpleado.Data;
                    if (empleado.Empl_Estado)
                    {
                        var responseUsuario = await _usuariosServicios.ObtenerUsuarioPorEmplId(empleado.Empl_Id);
                        if (responseUsuario.Success)
                        {
                            return Json(new { message = "Ya existe un usuario para esta persona." });
                        }
                        else
                        {
                             return Json(new { empleado = reponseEmpleado.Data, message = reponseEmpleado.Message });
                        }
                    }
                    else
                    {
                        return Json(new { message = "No existe un miembro de partido con este DNI." });
                    }
                }
                else
                {
                    return Json(new { message = "No existe un miembro de partido con este DNI." });
                }
            }
            catch (Exception ex)
            {
                return Json("Error al obtener la persona por el DNI");
            }
        }
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
                        var model = new List<UsuariosViewModel>();
                        var list = await _usuariosServicios.ObtenerUsuariosList();
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
        [HttpGet("[controller]/Details/{Usua_Id}")]
        public async Task<IActionResult> Details(string Usua_Id)
        {
            try
            {
                var model = new UsuariosViewModel();
                var list = await _usuariosServicios.ObtenerUsuario(Usua_Id);
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet("[controller]/Create")]
        public async Task<IActionResult> Create()
        {
            try
            {
                var result = await _rolesServicios.ObtenerRolesList();
                ViewBag.Roles = result.Data;
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UsuariosViewModel item)
        {
            try
            {
                if (item.Usua_Usuario == null)
                {
                    TempData["Advertencia"] = "Por favor ingrese un nombre de usuario.";
                    return View(item);
                }
                if (item.Empl_Id == 0)
                {
                    TempData["Advertencia"] = "Por favor ingrese el DNI de un miembro de partido político.";
                    return View(item);
                }
                if (item.Rol_Id == 0)
                {
                    TempData["Advertencia"] = "Por favor seleccione un rol para este usuario.";
                    return View(item);
                }
                if (item.Usua_Contra != null && item.Usua_Contra.Length > 5)
                {
                    if (item.Usua_Contra == item.Usua_ContraConfirmar)
                    {
                        item.Usua_UsuarioCreacion = 4;
                        item.Usua_FechaCreacion = DateTime.Now;
                        var result = await _usuariosServicios.CrearUsuarios(item);
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
                    else
                    {
                        TempData["Advertencia"] = "Las contraseñas no son iguales.";
                    }
                }
                else
                {
                    TempData["Advertencia"] = "La contraseña debe tener como mínimo 6 caracteres.";
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al crear el usuario.";
            }
            return View(item);
        }

        [HttpGet("[controller]/Edit/{Usua_Id}")]
        public async Task<IActionResult> Edit(string Usua_Id)
        {
            try
            {
                var model = await _usuariosServicios.ObtenerUsuario(Usua_Id);
                return Json(model.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("[controller]/Edit")]
        public async Task<IActionResult> Edit(UsuariosViewModel item)
        {
            try
            {
                item.Usua_UsuarioModifica = 4;
                item.Usua_FechaModifica = DateTime.Now;
                var result = await _usuariosServicios.EditarUsuarios(item);
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
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al editar el departamento";
                TempData["Item"] = JsonConvert.SerializeObject(item);
                return RedirectToAction("Index");
                throw;
            }
        }

        [HttpPost("/[controller]/DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed([FromForm] string Usua_Id)
        {
            try
            {
                var result = await _usuariosServicios.ActivarDesactivar(Usua_Id);
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
                TempData["Error"] = "Error al cambiarle el estado al usuario";
                return RedirectToAction("Index");
            }
        }
    }
}
