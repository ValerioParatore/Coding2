using MVC_scarpe.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MVC_scarpe.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            return View(DBscarpe.getAllScarpe());
        }
        public ActionResult AddProduct() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct (Scarpe scp, HttpPostedFileBase imgCopertina, HttpPostedFileBase imgN2, HttpPostedFileBase imgN3)
        {
            
            if(ModelState.IsValid)
            {
                if (imgCopertina.ContentLength >0)
                {
                    string imgName = imgCopertina.FileName;
                    string pathToSave = Path.Combine(Server.MapPath("~/Content/imgs"), imgName);
                    imgCopertina.SaveAs(pathToSave);
                }
                if (imgN2.ContentLength >0)
                {
                    string imgName = imgN2.FileName;
                    string pathToSave = Path.Combine(Server.MapPath("~/Content/imgs"), imgName);
                    imgCopertina.SaveAs(pathToSave);
                }
                if (imgN3.ContentLength >0)
                {
                    string imgName = imgN3.FileName;
                    string pathToSave = Path.Combine(Server.MapPath("~/Content/imgs"), imgName);
                    imgCopertina.SaveAs(pathToSave);
                }
                DBscarpe.AddScarpa(scp, imgCopertina, imgN2,imgN3);


                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Edit (int id) 
        {
            Scarpe scarpa = DBscarpe.getScarpaById(id);


            return View(scarpa);
        }
        [HttpPost]
        public ActionResult Edit (Scarpe scp, HttpPostedFileBase imgCopertina, HttpPostedFileBase imgN2, HttpPostedFileBase imgN3)
        {
            DBscarpe.UpdateScarpa(scp,imgCopertina,imgN2,imgN3);

            return View("Index");
        }
        public ActionResult Delete()
        {
               return View();
        }
        [HttpPost]
        public ActionResult Delete (int id)
        {

            DBscarpe.Remove(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Dettagli(int id)
        {
            Scarpe scpDtl = DBscarpe.getScarpaById(id);
            return View(scpDtl);
        }

        public ActionResult GrigliaProdotti ()
        {

            return View(DBscarpe.getAllScarpe());
        }
    }
}