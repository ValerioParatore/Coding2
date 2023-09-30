using ProgettoSettimanalePOLIZIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgettoSettimanalePOLIZIA.Controllers
{
    public class TrasgressioniController : Controller
    {
        // GET: Trasgressioni
        public ActionResult Trasgressioni()
        {
            ViewBag.listaVio = DB.getAllTipiVio();
            return View(DB.getAllTipiVio());
        }
        public ActionResult newViolazione() { return View(); }
        [HttpPost]
        public ActionResult newViolazione(TipoViolazioni v)
        {
            DB.addTipoViolazione(v);
            return RedirectToAction("Trasgressioni");
        }
    }
}