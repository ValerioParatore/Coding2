using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.NET
{
    public partial class Default : System.Web.UI.Page
    {
        public static double costoAuto {get;set;}
        public static double costoOptional { get;set;}
        public static double costoGaranzia { get;set;}

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            
            if (DropDownList1.SelectedValue == "peugeot-308.png")
            {
                costoAuto = 27670.00;
            }
            else if (DropDownList1.SelectedValue == "merced-benz-amg-gt.png")
            {
                costoAuto = 114000.00;
            }
            else if (DropDownList1.SelectedValue == "audi'-A3.png")
            {
                costoAuto = 28670.00;
            }
            for (int i = 0; i <= CheckBoxList1.Items.Count - 1; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    costoOptional += Convert.ToDouble(CheckBoxList1.Items[i].Value);
                }
            }
            if (DropDownList2.SelectedValue == "1")
            {
                costoGaranzia = 120.00;
            }
            else if (DropDownList2.SelectedValue == "2")
            {
                costoGaranzia = 240.00;
            }
            else if (DropDownList2.SelectedValue == "3")
            {
                costoGaranzia = 360.00;
            }
            else if (DropDownList2.SelectedValue == "4")
            {
                costoGaranzia = 480.00;
            }
            Label2.Text = $"Costo di partenza dell'auto uguale a : {Convert.ToString(costoAuto)} euro";
            Label3.Text = $"Costo totale degli optional uguale a : {Convert.ToString(costoOptional)} euro ";
            Label4.Text = $"Costo della garanzia uguale a : {Convert.ToString(costoGaranzia)} euro";
            Label5.Text = $"Total: {Convert.ToString(costoAuto + costoOptional + costoGaranzia)} euro";

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image1.ImageUrl = $"~/Content/imgs/{DropDownList1.SelectedValue}";
            if (DropDownList1.SelectedValue == "peugeot-308.png")
            {
                Label1.Text = "A partire da 27.670 euro";
            }else if (DropDownList1.SelectedValue == "merced-benz-amg-gt.png")
            {
                Label1.Text = "A partire da 114.000 euro";
            }else if (DropDownList1.SelectedValue == "audi'-A3.png")
            {
                Label1.Text = "A partire da 28.670 euro";
            }

        }
    }
}