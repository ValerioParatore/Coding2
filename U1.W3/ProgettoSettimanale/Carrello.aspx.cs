using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgettoSettimanale
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
           
            GridView1.DataSource = ItemsCarrello.carrellos ;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
           int id = Convert.ToInt32(btn.CommandArgument);
            foreach(ItemsCarrello item in ItemsCarrello.carrellos)
            {
                if(item.IDitem == id)
                {
                    ItemsCarrello.carrellos.Remove(item);
                    break;
                }
            }

        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            ItemsCarrello.carrellos.Clear();

        }
    }
}