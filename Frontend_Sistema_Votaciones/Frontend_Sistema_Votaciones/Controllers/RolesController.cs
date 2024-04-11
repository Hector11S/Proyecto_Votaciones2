﻿using Frontend_Sistema_Votaciones.Models;
using Frontend_Sistema_Votaciones.Servicios;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        private readonly PantallasPorRolesServicios _pantallasPorRolesServicios;
        public RolesController(RolesServicios rolesServicios, 
                PantallasServicios pantallasServicios, 
                PantallasPorRolesServicios pantallasPorRolesServicios)
        {
            _rolesServicios = rolesServicios;
            _pantallasServicios = pantallasServicios;
            _pantallasPorRolesServicios = pantallasPorRolesServicios;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<RolesViewModel>();
                var list = await _rolesServicios.ObtenerRolesList();
                return View(list.Data);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Roles");
            }
        }
        [HttpGet("[controller]/Create")]
        public async Task<IActionResult> Create()
        {
            try
            {
                var model = new RolesViewModel();
                var rolesList = await _rolesServicios.ObtenerRolesList();
                var pantallasList = await _pantallasServicios.ObtenerPantallasList();
                var pantallasPorRolesList = await _pantallasPorRolesServicios.ObtenerParoList();
                ViewBag.Roles = rolesList.Data;
                ViewBag.Pantallas = pantallasList.Data;
                ViewBag.PantallasPorRoles = JsonConvert.SerializeObject(pantallasPorRolesList.Data);

                Dictionary<int, string> uniqueEsquemas = new Dictionary<int, string>();
                foreach (var pantalla in (List<PantallasViewModel>)pantallasList.Data)
                {
                    uniqueEsquemas[pantalla.Esqu_Id] = pantalla.Esqu_Descripcion;
                }
                ViewBag.Esquemas = uniqueEsquemas;
                return View();
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }
        [HttpGet("[controller]/Details/{Rol_Id}")]
        public async Task<IActionResult> Details(int Rol_Id)
        {
            try
            {
                var model = new RolesViewModel();
                var list = await _rolesServicios.ObtenerRoles(Rol_Id);
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RolesViewModel item)
        {
            try
            {
                item.Rol_UsuarioCreacion = 4;
                item.Rol_FechaCreacion = DateTime.Now;
                var result = await _rolesServicios.CrearRoles(item);
                if (result.Success)
                {
                    item.Rol_Id = result.Id;
                    TempData["AbrirModal"] = null;
                    TempData["Exito"] = result.Message;
                }
                else
                {
                    TempData["AbrirModal"] = TiposDeModal.Nuevo;
                    TempData["Item"] = JsonConvert.SerializeObject(item);
                    TempData["Advertencia"] = result.Message;
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al crear la mesa.";
                TempData["Item"] = JsonConvert.SerializeObject(item);
            }
            return View(item);
        }

        [HttpGet("[controller]/Edit")]
        public async Task<IActionResult> Edit(int Rol_Id)
        {
            try
            {
                var model = await _rolesServicios.ObtenerRoles(Rol_Id);
                var rolesList = await _rolesServicios.ObtenerRolesList();
                var pantallasList = await _pantallasServicios.ObtenerPantallasList();
                var pantallasPorRolesList = await _pantallasPorRolesServicios.ObtenerParoList();
                ViewBag.Roles = rolesList.Data;
                ViewBag.Pantallas = pantallasList.Data;
                ViewBag.ParoIEnumerable = pantallasPorRolesList.Data;
                ViewBag.PantallasPorRoles = JsonConvert.SerializeObject(pantallasPorRolesList.Data);

                Dictionary<int, string> uniqueEsquemas = new Dictionary<int, string>();
                foreach (var pantalla in (List<PantallasViewModel>)pantallasList.Data)
                {
                    uniqueEsquemas[pantalla.Esqu_Id] = pantalla.Esqu_Descripcion;
                }
                ViewBag.Esquemas = uniqueEsquemas;
                return View(model.Data);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("[controller]/Edit")]
        public async Task<IActionResult> Edit(RolesViewModel item)
        {
            try
            {
                item.Rol_UsuarioModifica = 4;
                item.Rol_FechaModifica = DateTime.Now;
                var result = await _rolesServicios.EditarRoles(item);
                if (result.Success)
                {
                    TempData["AbrirModal"] = null;
                    TempData["Exito"] = result.Message;
                }
                else
                {
                    TempData["AbrirModal"] = TiposDeModal.Editar;
                    TempData["Item"] = JsonConvert.SerializeObject(item);
                    TempData["Advertencia"] = result.Message;
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al editar la mesa";
                TempData["Item"] = JsonConvert.SerializeObject(item);
            }
            return View(item);
        }

        [HttpPost("/[controller]/DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed([FromForm] string Rol_Id)
        {
            try
            {
                var result = await _rolesServicios.EliminarRoles(Rol_Id);
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
                TempData["Error"] = "Error dentro del código de la aplicación. Por favor contacte a un administrador del sistema";
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public async Task<IActionResult> CreatePantallasPorRoles(int Rol_Id, int Pant_Id)
        {
            try
            {
                var paro = new PantallasPorRolesViewModel();
                paro.Rol_Id = Rol_Id;
                paro.Pant_Id = Pant_Id;
                var result = await _pantallasPorRolesServicios.CrearParo(paro);
                if (result.Success)
                {
                    return Json(new { result = true, message = result.Message });
                }
                else
                {
                    return Json(new { result = false, message = result.Message });
                }
            }
            catch (Exception ex)
            {
                return Json(new { result = false, message = $"Error al vincular la pantalla {Pant_Id} al rol {Rol_Id}." });
            }
        }
        [HttpGet]
        public async Task<IActionResult> CreateEsquemaPorRoles(int Rol_Id, int Esqu_Id)
        {
            try
            {
                var paro = new PantallasPorRolesViewModel();
                paro.Rol_Id = Rol_Id;
                paro.Esqu_Id = Esqu_Id;
                var result = await _pantallasPorRolesServicios.CrearParoPorEsqu(paro);
                if (result.Success)
                {
                    return Json(new { result = true, message = result.Message });
                }
                else
                {
                    return Json(new { result = false, message = result.Message });
                }
            }
            catch (Exception ex)
            {
                return Json(new { result = false, message = $"Error al vincular las pantallas del esquema {Esqu_Id} al rol {Rol_Id}." });
            }
        }
        [HttpDelete]
        public async Task<IActionResult> DeletePantallasPorRoles(int Rol_Id, int Pant_Id)
        {
            try
            {
                var result = await _pantallasPorRolesServicios.EliminarParo(Rol_Id, Pant_Id);
                if (result.Success)
                {
                    return Json(new { result = true, message = result.Message });
                }
                else
                {
                    return Json(new { result = false, message = result.Message });
                }
            }
            catch (Exception ex)
            {
                return Json(new { result = false, message = $"Error al desvincular la pantalla {Pant_Id} al rol {Rol_Id}." });
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEsquemaPorRoles(int Rol_Id, int Esqu_Id)
        {
            try
            {
                var result = await _pantallasPorRolesServicios.EliminarParoPorEsqu(Rol_Id, Esqu_Id);
                if (result.Success)
                {
                    return Json(new { result = true, message = result.Message });
                }
                else
                {
                    return Json(new { result = false, message = result.Message });
                }
            }
            catch (Exception ex)
            {
                return Json(new { result = false, message = $"Error al desvincular las pantallas del esquema {Esqu_Id} al rol {Rol_Id}." });
            }
        }
    }
}
