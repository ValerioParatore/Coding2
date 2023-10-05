using Spedizioni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Spedizioni.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index () { return View(); }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin u)
        {
            DB.isAdmin(u);
            if(DB.isAdmin(u) == true)
            {
                HttpCookie cookie = new HttpCookie("admin");
                cookie.Values["Username"] = "admin";
                Response.Cookies.Add(cookie);
                FormsAuthentication.SetAuthCookie(u.Username, false);
                return RedirectToAction("Index", "Home");
            }else
            {
                ViewBag.AuthError = "Autenticazione non riuscita";
            }return RedirectToAction("Index", "Home");  
            
        }
        public ActionResult logout ()
        {
            HttpCookie cookie = new HttpCookie ("admin");
            cookie.Expires= DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
            return RedirectToAction("Index", "Home");
        }
    }
}