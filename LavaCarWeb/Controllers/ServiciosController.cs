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
    public class ServiciosController : Controller
    {

        //Get: /Servicios

        public ActionResult Index()
        {
            return View(ServiciosN.GetServicios());
        }

        public ActionResult Create()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Servicios servicio)
        {
            try
            {
                ServiciosN.Agregar(servicio);
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
            var servicio = ServiciosN.ObtenerServicio(id);
            return View(servicio);
        }

        public ActionResult Edit(int id)
        {
            var servicio = ServiciosN.ObtenerServicio(id);
            return View(servicio);
        }


        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Servicios servicio)
        {
            try
            {
                ServiciosN.Editar(servicio);
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
                ServiciosN.Eliminar(identificador);
                return Json(new { ok = true, toRedirect = Url.Action("Index") }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { ok = false, msg = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
