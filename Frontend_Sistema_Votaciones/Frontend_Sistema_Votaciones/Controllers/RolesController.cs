using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Controllers
{
    public class RolesController : Controller
    {
        private readonly RolesServicios _rolesServicios;
        private readonly PantallasServicios _pantallasServicios;
        public RolesController(RolesServicios rolesServicios, PantallasServicios pantallasServicios)
        {
            _rolesServicios = rolesServicios;
            _pantallasServicios = pantallasServicios;
        }
        public async Task<IActionResult> Index()
        {
            var model = new List<RolesViewModel>();
            var list = await _rolesServicios.ObtenerRolesList();
            return View(list.Data);
        }
        public async Task<IActionResult> Create()
        {
            var model = new List<RolesViewModel>();
            var rolesList = await _rolesServicios.ObtenerRolesList();
            var pantallasList = await _pantallasServicios.ObtenerPantallasList();
            ViewBag.Roles = rolesList.Data;
            ViewBag.Pantallas = pantallasList.Data;

            HashSet<string> uniqueEsquemas = new HashSet<string>();
            foreach (var pantalla in (List<PantallasViewModel>)pantallasList.Data)
            {
                uniqueEsquemas.Add(pantalla.Pant_Esquema);
            }
            ViewBag.Esquemas = uniqueEsquemas;
            return View();
        }
    }
}
