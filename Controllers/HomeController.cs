using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaVentas.Models;

namespace SistemaVentas.Controllers
{
    public class HomeController : Controller
    {

        private AguilaCurdaEntities db = new AguilaCurdaEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Nosotros()
        {

            return View();
        }

        public ActionResult Contacto()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contacto([Bind(Include = "id_consulta,nombre,email,comentario")] Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                db.Consulta.Add(consulta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(consulta);
        }

        

    }
}