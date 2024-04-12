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
    public class VotantesController : Controller
    {
        private readonly EmpleadoServicios _empleadoServicios;
        private readonly VotanteServicios _votanteServicios;
        private readonly DepartamentoServicios _departamentoServicios;
        private readonly MunicipioServicios _municipioServicios;
        private readonly PartidoServicios _partidoServicios;
        private readonly CargoServicios _cargoServicios;
        private readonly SedesServicios _sedesServicios;
        private readonly MesasServicios _mesasServicios;
        private readonly EstadosCivilesServicios _estadosCivilesServicios;
        private readonly IWebHostEnvironment _hostingEnviroment;


        public VotantesController(
            EmpleadoServicios empleadoServicios,
            VotanteServicios votanteServicios,
            DepartamentoServicios departamentoServicios,
            MunicipioServicios municipioServicios,
            PartidoServicios partidoServicios,
            CargoServicios cargoServicios,
            SedesServicios sedesServicios,
            MesasServicios mesasServicios,
            EstadosCivilesServicios estadosCivilesServicios,

            IWebHostEnvironment hostingEnviroment)
        {
            _cargoServicios = cargoServicios;
            _empleadoServicios = empleadoServicios;
            _votanteServicios = votanteServicios;
            _departamentoServicios = departamentoServicios;
            _municipioServicios = municipioServicios;
            _partidoServicios = partidoServicios;
            _sedesServicios = sedesServicios;
            _mesasServicios = mesasServicios;
            _estadosCivilesServicios = estadosCivilesServicios;
            _hostingEnviroment = hostingEnviroment;
        }

        [HttpGet("[controller]/ObtenerMunicipiosPorDept/{Dept_Codigo}")]
        public async Task<IActionResult> ObtenerMunicipios(string Dept_Codigo)
        {
            try
            {
                var response = await _municipioServicios.ObtenerMunicipiosList(Dept_Codigo);
                return Json(new { municipios = response.Data, message = response.Message });
            }
            catch (Exception ex)
            {
                return Json(new { message = "Error al cargar los municipios" });
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
                        var model = new List<VotanteViewModel>();
                        var list = await _votanteServicios.ObtenerVotanteList();
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

        [HttpGet("[controller]/Details/{Vota_DNI}")]
        public async Task<IActionResult> Details(string Vota_DNI)
        {
            try
            {
                var model = new VotanteViewModel();
                var list = await _votanteServicios.ObtenerVotantePorDNI(Vota_DNI);
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
                var departamentosList = await _departamentoServicios.ObtenerDepartamentoList();
                var partidosList = await _partidoServicios.ObtenerPartidoList();
                ViewBag.Departamentos = departamentosList.Data;
                ViewBag.Partidos = partidosList.Data;

                var estados = await _estadosCivilesServicios.ObtenerEstadosCivilesList();
                ViewBag.estadosCiviles = estados.Data;

                var sedes = await _sedesServicios.ObtenerSedesList();
                ViewBag.Sedes = sedes.Data;

                var Mesas = await _mesasServicios.ObtenerMesasList();
                ViewBag.Mesas = Mesas.Data;

                var CargosList = await _cargoServicios.ObtenerCargoList();
                ViewBag.Cargos = CargosList.Data;
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
        public async Task<IActionResult> Create(VotanteViewModel item)
        {
            try
            {
                item.Vota_YaVoto = false;
                item.Vota_Permitido = false;
                item.Vota_UsuarioCreacion = 4;
                item.Vota_FechaCreacion = DateTime.Now;
                var result = await _votanteServicios.CrearVotante(item);
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
                TempData["Error"] = "Error al crear el registro de la persona.";
            }
            return View(item);
        }
        [HttpGet("[controller]/Edit/{Vota_DNI}")]
        public async Task<IActionResult> Edit(string Vota_DNI)
        {
            try
            {
                var model = await _votanteServicios.ObtenerVotantePorDNI(Vota_DNI);
                return View(model.Data);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al cargar la información de la persona";
            }
            return View();
        }

        [HttpPost("[controller]/Edit")]
        public async Task<IActionResult> Edit(VotanteViewModel item)
        {
            try
            {
                item.Vota_UsuarioModifica = 4;
                item.Vota_FechaModifica = DateTime.Now;
                var result = await _votanteServicios.EditarVotante(item);
                if (result.Success)
                {
                    TempData["Exito"] = result.Message;
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Advertencia"] = result.Message;
                    return View(item);
                }
            }
            catch (Exception ex)
            {
            }
            return View(item);
        }
        [HttpPost("/[controller]/DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed([FromForm] string Vota_DNI)
        {
            try
            {
                var result = await _votanteServicios.EliminarVotante(Vota_DNI);
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
                TempData["Error"] = "Error al cargar la información de la persona";
                return RedirectToAction("Index");
            }
        }
    }
}
