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
    public class EmpleadosController : Controller
    {
        private readonly EmpleadoServicios _empleadoServicios;
        private readonly VotanteServicios _votanteServicios;
        private readonly DepartamentoServicios _departamentoServicios;
        private readonly MunicipioServicios _municipioServicios;
        private readonly PartidoServicios _partidoServicios;
        private readonly CargoServicios _cargoServicios;
        private readonly SedesServicios _sedesServicios;
        private readonly MesasServicios _mesasServicios;
        private readonly IWebHostEnvironment _hostingEnviroment;


        public EmpleadosController(
            EmpleadoServicios empleadoServicios,
            VotanteServicios votanteServicios,
            DepartamentoServicios departamentoServicios,
            MunicipioServicios municipioServicios,
            PartidoServicios partidoServicios,
            CargoServicios cargoServicios,
            SedesServicios sedesServicios,
            MesasServicios mesasServicios,
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
            _hostingEnviroment = hostingEnviroment;
        }

        [HttpGet("[controller]/ObtenerVotantePorDNI/{Vota_DNI}")]
        public async Task<IActionResult> ObtenerVotantePorDNI(string Vota_DNI)
        {
            try
            {

                var reponseVotante = await _votanteServicios.ObtenerVotantePorDNI(Vota_DNI);
                VotanteViewModel votante = (VotanteViewModel)reponseVotante.Data;
                var responseAlcalde = await _empleadoServicios.ObtenerEmpleado(Convert.ToInt32(votante.Vota_Id));
                if (responseAlcalde.Success)
                {
                    return Json(new { message = "Ya existe un registro de este Empleado." });
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
                var model = new List<EmpleadoViewModel>();
                var list = await _empleadoServicios.ObtenerEmpleadoList();
                
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet("[controller]/Details/{Empl_Id}")]
        public async Task<IActionResult> Details(int Empl_Id)
        {
            try
            {
                var model = new EmpleadoViewModel();
                var list = await _empleadoServicios.ObtenerEmpleado(Empl_Id);
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
        public async Task<IActionResult> Create(EmpleadoViewModel item)
        {
            try
            {
                item.Empl_UsuarioCreacion = 4;
                item.Empl_FechaCreacion = DateTime.Now;
                var result = await _empleadoServicios.CrearEmpleado(item);
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
                TempData["Error"] = "Error al crear el empleado.";
            }
            return View(item);
        }
        //[HttpGet("[controller]/Edit")]
        public async Task<IActionResult> Edit(int Empl_Id)
        {
            try
            {
                var departamentosList = await _departamentoServicios.ObtenerDepartamentoList();
                var partidosList = await _partidoServicios.ObtenerPartidoList();
                ViewBag.Departamentos = departamentosList.Data;
                ViewBag.Partidos = partidosList.Data;
                var response = await _empleadoServicios.ObtenerEmpleado(Empl_Id);
                EmpleadoViewModel empleadoViewModel = (EmpleadoViewModel)response.Data;
                var municipios = await _municipioServicios.ObtenerMunicipiosList(empleadoViewModel.Dept_Codigo);
                ViewBag.Municipios = municipios.Data;
                return View(response.Data);
            }
            catch (Exception ex)
            {
                TempData["Error"] = $"Error al cargar informacion del Empleado {Empl_Id}.";
                return View();
            }
        }

        [HttpPost("[controller]/Edit")]
        public async Task<IActionResult> Edit(EmpleadoViewModel item)
        {
            try
            {
                item.Empl_UsuarioModifica = 4;
                item.Empl_FechaModifica = DateTime.Now;
                var result = await _empleadoServicios.EditarEmpleado(item);
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
                TempData["Error"] = "Error al editar el alcalde.";
            }
            return RedirectToAction("Edit", "Empleado", new { Empl_Id = item.Empl_Id });
        }

        [HttpGet("[controller]/ObtenerSedesPorMunicipio/{Muni_Codigo}")]
        public async Task<IActionResult> ObtenerSedesPorMunicipio(string Muni_Codigo)
        {
            try
            {
                var response = await _empleadoServicios.ObtenerSedesPorMunicipio(Muni_Codigo);
                if (response.Success)
                {
                    var sedes = (IEnumerable<SedesViewModel>)response.Data;
                    return Json(new { sedes = sedes, message = response.Message });
                }
                else
                {
                    return Json(new { message = response.Message });
                }
            }
            catch (Exception ex)
            {
                return Json(new { message = "Error al obtener las sedes por municipio" });
            }
        }


    }
}
