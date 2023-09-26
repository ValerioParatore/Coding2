using Fatture_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fatture_mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Creat() 
        {

            return View();
        }
        [HttpPost]
        public ActionResult Creat(Fatture f) 
        {
            if (ModelState.IsValid)
            {
                Fatture.FattureList.Add(f);
                return RedirectToAction("Index");
            } else
            {
                return View();
            }
        }


      
        public ActionResult PartialListaFatture()
        {

            return PartialView("_PartialView" , Fatture.FattureList);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}