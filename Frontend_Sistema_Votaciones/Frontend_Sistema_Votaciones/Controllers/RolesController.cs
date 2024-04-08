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
        [HttpGet]
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
                    TempData["AbrirModal"] = null;
                    TempData["Exito"] = result.Message;
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["AbrirModal"] = TiposDeModal.Nuevo;
                    TempData["Item"] = JsonConvert.SerializeObject(item);
                    TempData["Advertencia"] = result.Message;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al crear la mesa.";
                TempData["Item"] = JsonConvert.SerializeObject(item);
                return RedirectToAction("Index");
            }
        }

        [HttpGet("[controller]/Edit/{Rol_Id}")]
        public async Task<IActionResult> Edit(int Rol_Id)
        {
            try
            {
                var model = await _rolesServicios.ObtenerRoles(Rol_Id);
                return Json(model.Data);
            }
            catch (Exception ex)
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
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["AbrirModal"] = TiposDeModal.Editar;
                    TempData["Item"] = JsonConvert.SerializeObject(item);
                    TempData["Advertencia"] = result.Message;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al editar la mesa";
                TempData["Item"] = JsonConvert.SerializeObject(item);
                return RedirectToAction("Index");
                throw;
            }
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
    }
}
