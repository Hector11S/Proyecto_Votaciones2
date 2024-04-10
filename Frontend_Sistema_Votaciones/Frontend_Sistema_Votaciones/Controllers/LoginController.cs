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
    public class LoginController : Controller
    {
        private readonly UsuariosServicios _usuariosServicios;
        private readonly Autorizacion _autorizacion;
        private readonly PantallasPorRolesServicios _pantallasPorRolesServicios;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginController(
            UsuariosServicios usuariosServicios,
            Autorizacion _autorizacion,
            PantallasPorRolesServicios pantallasPorRolesServicios,
            IHttpContextAccessor httpContextAccessor)
        {
            _usuariosServicios = usuariosServicios;
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IniciarSesion(UsuariosViewModel item) {
            try
            {

                var resultPantallasPorRoles = await _pantallasPorRolesServicios.ObtenerParoList();
                if (resultPantallasPorRoles.Success)
                {
                    var pantallasPorRolesList = (List<PantallasPorRolesViewModel>)resultPantallasPorRoles.Data;
                    _autorizacion.SetearPantallasPorRoles(pantallasPorRolesList);
                    var result = await _usuariosServicios.IniciarSesion(item);
                    if (result.Success)
                    {
                        TempData["Exito"] = result.Message;
                        return RedirectToAction("Index", "Home");
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
                throw;
            }
            return View(item);
        }
    }
}
