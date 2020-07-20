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
    public class VehiculoController : Controller
    {
        public ActionResult Index()
        {
            return View(VehiculoN.GetVehiculo());
        }

        public ActionResult Create()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vehiculo vehiculo)
        {
            try
            {
                VehiculoN.Agregar(vehiculo);
                //return Json(new { ok = true, toRedirect = Url.Action("Index") }, JsonRequestBehavior.AllowGet);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                //return Json(new { ok = false, msg = ex.Message }, JsonRequestBehavior.AllowGet);
                ModelState.AddModelError("", "Ocurrió un error al agregar un Empleado");
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            var vehiculo = VehiculoN.ObtenerVehiculo(id);
            return View(vehiculo);
        }

        public ActionResult Edit(int id)
        {
            var vehiculo = VehiculoN.ObtenerVehiculo(id);
            return View(vehiculo);
        }

        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Vehiculo vehiculo)
        {
            try
            {
                VehiculoN.Editar(vehiculo);
                return Json(new { ok = true, toRedirect = Url.Action("Index") }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { ok = false, msg = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }


        public ActionResult Delete()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult Delete(int identificador)
        {
            try
            {
                VehiculoN.Eliminar(identificador);
                return Json(new { ok = true, toRedirect = Url.Action("Index") }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { ok = false, msg = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
