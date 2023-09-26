using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgettoSettimanale
{
    public partial class Dettagli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["IDitem"]);
            foreach (Prodotto item in Prodotto.items)
            {
                if (item.IDitem == id)
                {
                    itemName.InnerText = item.NameItem;
                    itemDes.InnerText = item.DescriptionItem;
                    itemImg.Src = item.ImgItem;
                    itemPrezzo.InnerText = item.PrezzoItem.ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["IDitem"]);
            string nameItem = itemName.InnerText;
            double prezzoItem = Convert.ToDouble(itemPrezzo.InnerText);
            
            ItemsCarrello itemCarrello = new ItemsCarrello(id,nameItem,prezzoItem);
            ItemsCarrello.carrellos.Add(itemCarrello);
        }

    }
    public class ItemsCarrello
    {
        public int IDitem { get; set; }
        public string NameItem;
        public double PrezzoItem;
        public ItemsCarrello(int id, string nome, double prezzo)
        {
            IDitem = id;
            NameItem = nome;
            PrezzoItem = prezzo;
        }
        public static List<ItemsCarrello> carrellos = new List<ItemsCarrello>();
    }
}