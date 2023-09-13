using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EsercizioPizze.pizzeria
{
    public partial class pizze : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            stampa.Visible = true;
            if (Request.Cookies[".ASPXAUTH"] == null)
            {
                Response.Redirect("https://localhost:44353/pizzeria/Default");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Pizze.nomePizza = DropDownList1.SelectedItem.Text;
            Ingredienti.ingredientis.Clear();
            Pizze.prezzoPizza = Convert.ToDouble(DropDownList1.SelectedItem.Value);
            Pizze.prezzoIngredienti = 0;
            for(int i = 0; i <= ingredienti.Items.Count -1; i++)
            {
                if (ingredienti.Items[i].Selected)
                {
                    Pizze.prezzoIngredienti+= Convert.ToDouble(ingredienti.Items[i].Value);
                    Ingredienti.ingredientis.Add(ingredienti.Items[i].ToString());
                }
            }
            Pizze.PrezzoTot = Pizze.prezzoPizza + Pizze.prezzoIngredienti;
            Pizze.pizzeIngredienti();
            string testoStampa = "";
            foreach (string pizze in Pizze.pizzeTot)
            {
                testoStampa += pizze;
            }
            Pizze.stampe.Add($"{testoStampa}");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach(string text in Pizze.stampe)
            {
                stampa.InnerText = $"{text} ";
            }
        }
    }
    public class Pizze
    {
        public static string Ingrediente { get; set; }
        public static double prezzoIngredienti = 0;
        public static string nomePizza { get; set; }
        public static double prezzoPizza = 0;
        public static double PrezzoTot = 0;

        public static List<string> pizzeTot = new List<string>();
        public static void pizzeIngredienti ()
        {
            pizzeTot.Add($"Pizza {nomePizza} con aggiunta dei seguenti condimenti: ");
           
            foreach (string ing in Ingredienti.ingredientis)
            {
                pizzeTot.Add($" {ing},");
            }
            pizzeTot.Add($" costo totale pizza: {PrezzoTot}");
        }
        public static List<string> stampe = new List<string>();
    }
    public class Ingredienti
    {
        public static string ingredienti { get; set; }
        public Ingredienti (string ingrediente)
        {
            ingredienti= ingrediente;
        }
        public static List<string> ingredientis = new List<string>();
    }
}