using ProgettoSettimanalePOLIZIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgettoSettimanalePOLIZIA.Controllers
{
    public class VerbaliController : Controller
    {
        // GET: Verbali
        public ActionResult Verbali()
        {
            return View();
        }
        public ActionResult NewVerbale()
        {

            return View();
        }

        [HttpPost]
        public ActionResult NewVerbale (Verbali ver)
        {
            DB.addVerbale(ver);
            return RedirectToAction("Verbali");
        }
        public ActionResult showOver10p()
        {
            return View(DB.verbaliOver10P());
        }
        public ActionResult showOver400()
        {
            return View(DB.verbaliOver400());
        }

        public ActionResult totPid (int id)
        {
            return View(DB.totPuntiDec(id));
        }
    }
}