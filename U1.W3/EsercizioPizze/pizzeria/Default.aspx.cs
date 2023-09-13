using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EsercizioPizze.pizzeria
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            alert.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = ConfigurationManager.AppSettings["user"].ToString();
            string password = ConfigurationManager.AppSettings["password"].ToString();
            if (username == TextBox1.Text && password == TextBox2.Text)
            {
                FormsAuthentication.SetAuthCookie(TextBox1.Text, false);
                Response.Redirect(FormsAuthentication.DefaultUrl);
            }
            else
            {
                alert.Visible = true;
            }
        }
    }
}