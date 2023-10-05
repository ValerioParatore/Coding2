using Spedizioni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Spedizioni.Controllers
{
    public class GestionePrivatiController : Controller
    {
        // GET: GestionePrivati
        public ActionResult Index()
        {
            return View(DB.getAllUtenti());
        }
        public ActionResult addPriv ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addPriv(Utente u)
        {
            if(ModelState.IsValid)
            {
                DB.addUtente(u);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}