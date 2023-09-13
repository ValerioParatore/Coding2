using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.Net.Stato
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
            if (Request.Cookies["ASPNET_COOKIE"]==null)
            {
                Response.Redirect("https://localhost:44342/WebForm1");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (DropDownList1.SelectedItem.Value == "1")
            {
                if(CheckBox1.Checked)
                {
                    Sale.salaNord++;
                    Sale.salaNordRid++;
                    panr.InnerHtml = $"{Sale.salaNordRid}";
                    pan.InnerHtml = $"{Sale.salaNord}";
                    prn.InnerHtml = $"{Sale.postiRimanentiNord()}";
                }
                else
                {
                    Sale.salaNord++;
                    panr.InnerHtml = $"{Sale.salaNordRid}";
                    pan.InnerHtml = $"{Sale.salaNord}";
                    prn.InnerHtml = $"{Sale.postiRimanentiNord()}";
                }
            }else if (DropDownList1.SelectedItem.Value == "2")
            {
                if (CheckBox1.Checked)
                {
                    Sale.salaEst++;
                    Sale.salaEstRid++;
                    paer.InnerHtml = $"{Sale.salaEstRid}";
                    pae.InnerHtml = $"{Sale.salaEst}";
                    pre.InnerHtml = $"{Sale.postiRimanentiEst()}";
                }
                else
                {
                    Sale.salaEst++;
                    paer.InnerHtml = $"{Sale.salaEstRid}";
                    pae.InnerHtml = $"{Sale.salaEst}";
                    pre.InnerHtml = $"{Sale.postiRimanentiEst()}";
                }
            }else if (DropDownList1.SelectedItem.Value == "3")
            {
                if (CheckBox1.Checked)
                {
                    Sale.salaSud++;
                    Sale.salaSudRid++;
                    pasr.InnerHtml = $"{Sale.salaSudRid}";
                    pas.InnerHtml = $"{Sale.salaSud}";
                    prs.InnerHtml = $"{Sale.postiRimanentiSud()}";
                }
                else
                {
                    Sale.salaSud++;
                    pasr.InnerHtml = $"{Sale.salaSudRid}";
                    pas.InnerHtml = $"{Sale.salaSud}";
                    prs.InnerHtml = $"{Sale.postiRimanentiSud()}";
                }
            }
        }
    }
    public class Sale
    {
        public static int salaNord { get;set; }
        public static int salaNordRid { get;set; }
        public static int salaEst { get;set; }
        public static int salaEstRid { get;set; }
        public static int salaSud { get;set; }
        public static int salaSudRid { get;set; }
        public static int postiRimanentiNord()
        {
            return 120 - (salaNord + salaNordRid);
        }
        public static int postiRimanentiEst ()
        {
            return 120 - (salaEst + salaEstRid);
        }
        public static int postiRimanentiSud ()
        {
            return 120 - (salaSud + salaSudRid);
        }
        
    }
}