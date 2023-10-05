using Spedizioni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Spedizioni.Controllers
{
    public class GestioneAziendeController : Controller
    {
        // GET: GestioneAziende
        public ActionResult Index()
        {
            return View(DB.getAllAziende());
        }


        public ActionResult addAzienda()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addAzienda(Aziende az)
        {
            if(ModelState.IsValid)
            {
                DB.addAzienda(az);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}