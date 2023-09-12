using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.Net.Stato
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("ASPNET_COOKIE");
            cookie.Values["Nome"] = TextBox1.Text;
            cookie.Values["Cognome"] = TextBox2.Text;
            cookie.Values["Password"] = TextBox3.Text;
            cookie.Expires = DateTime.Now.AddMinutes(3);
            Response.Cookies.Add(cookie);
            Response.Redirect("https://localhost:44342/WebForm2");
        }
    }

}