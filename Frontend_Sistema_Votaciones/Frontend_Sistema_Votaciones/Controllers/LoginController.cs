using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class LoginController : Controller
    {
        private readonly UsuariosServicios _usuariosServicios;
        private readonly PantallasPorRolesServicios _pantallasPorRolesServicios;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginController(
            UsuariosServicios usuariosServicios,
            PantallasPorRolesServicios pantallasPorRolesServicios,
            IHttpContextAccessor httpContextAccessor)
        {
            _usuariosServicios = usuariosServicios;
            _httpContextAccessor = httpContextAccessor;
            _pantallasPorRolesServicios = pantallasPorRolesServicios;
        }
        public IActionResult Index()
        {
            var model = new UsuariosViewModel();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UsuariosViewModel item) {
            try
            {
                if (item.Usua_Usuario == null && item.Usua_Contra == null)
                {
                    ViewBag.Usua_Usuario_Message = "Ingrese su nombre de usuario";
                    ViewBag.Usua_Contra_Message = "Ingrese su contraseña";
                    return View(item);
                }
                if (item.Usua_Usuario == null)
                {
                    ViewBag.Usua_Usuario_Message = "Ingrese su nombre de usuario";
                    return View(item);
                }
                if (item.Usua_Contra == null)
                {
                    ViewBag.Usua_Contra_Message = "Ingrese su contraseña";
                    return View(item);
                }

                var resultPantallasPorRoles = await _pantallasPorRolesServicios.ObtenerParoList();
                if (resultPantallasPorRoles.Success)
                {
                    var pantallasPorRolesList = (List<PantallasPorRolesViewModel>)resultPantallasPorRoles.Data;
                    Dictionary<int, HashSet<PantallasViewModel>> paroDictionary = Autorizacion.SetearPantallasPorRoles(pantallasPorRolesList);
                    string paroStr = JsonConvert.SerializeObject(paroDictionary);
                    HttpContext.Session.SetString("paroDictionary", paroStr);
                    var result = await _usuariosServicios.IniciarSesion(item);
                    if (result.Success)
                    {
                        UsuariosViewModel usuario = (UsuariosViewModel) result.Data;
                        if ((bool)usuario.Usua_Activo)
                        {
                            HttpContext.Session.SetInt32("Rol_Id", usuario.Rol_Id);
                            HttpContext.Session.SetString("Vota_NombreCompleto", usuario.Vota_NombreCompleto);
                            HttpContext.Session.SetString("Usua_Imagen", usuario.Usua_Imagen);
                            HttpContext.Session.SetString("Muni_Codigo", usuario.Muni_Codigo);
                            //TempData["Exito"] = result.Message;
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else
                    {
                        TempData["Advertencia"] = result.Message;
                    }
                }
                else
                {
                    TempData["Advertencia"] = resultPantallasPorRoles.Message;
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al iniciar sesión";
            }
            return View(item);
        }
    }
}
