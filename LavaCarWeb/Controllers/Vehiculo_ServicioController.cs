using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Entidad;
using LogicaNegocio;

namespace LavaCarWeb.Controllers
{
    public class Vehiculo_ServicioController : Controller
    {

        public ActionResult Index()
        {
            return View(Vehiculo_ServicioN.GetVehiculo_Servicio());

        }

        public ActionResult Create()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vehiculo_Servicio vehiculo_Servicio)
        {
            try
            {
                Vehiculo_ServicioN.Agregar(vehiculo_Servicio);
                //return Json(new { ok = true, toRedirect = Url.Action("Index") }, JsonRequestBehavior.AllowGet);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Json(new { ok = false, msg = ex.Message }, JsonRequestBehavior.AllowGet);
                ModelState.AddModelError("", "Ocurrió un error al agregar un Empleado");
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            var vehiculoServicio = Vehiculo_ServicioN.ObtenerVehiculo_Servicio(id);
            return View(vehiculoServicio);
        }

        public ActionResult Edit(int id)
        {
            var vehiculoServicio = Vehiculo_ServicioN.ObtenerVehiculo_Servicio(id);
            return View(vehiculoServicio);
        }

        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Vehiculo_Servicio vehiculo_Servicio)
        {
            try
            {
                Vehiculo_ServicioN.Editar(vehiculo_Servicio);
                return Json(new { ok = true, toRedirect = Url.Action("Index") }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { ok = false, msg = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}
