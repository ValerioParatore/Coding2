using Spedizioni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Spedizioni.Controllers
{
    public class SpedizioniController : Controller
    {
        // GET: Spedizioni
        public ActionResult Index()
        {
            return View(DB.getAllClientiSpedizioni());
        }
        public ActionResult DettagliSpedizione(int id)
        {
            Spedizione sp = DB.getClienteSpedizione(id);
            return View(sp);
        }
        public ActionResult addSpedizione ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addSpedizione (Spedizione sp)
        {
            if (ModelState.IsValid)
            {
                DB.addSpedizione(sp);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult statoSpedizione()
        {
            return View(DB.getStatoPerID(1));
        }

        public ActionResult addStatoSpedizione()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addStatoSpedizione(StatoSpedizione stato)
        {
            if (ModelState.IsValid)
            {
                DB.addStatoSpedizione(stato);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

    }
}