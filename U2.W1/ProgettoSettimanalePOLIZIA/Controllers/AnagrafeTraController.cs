using ProgettoSettimanalePOLIZIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgettoSettimanalePOLIZIA.Controllers
{
    public class AnagrafeTraController : Controller
    {
        // GET: AnagrafeTra
        public ActionResult AnagrafeTra()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AnagrafeTra(Anagrafe tras)
        {
            if (ModelState.IsValid)
            {
                DB.addTras(tras);
                return RedirectToAction("AnagrafeTra");
            }else { return View(); }
            
        }
    }
}