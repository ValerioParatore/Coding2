using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace Progetto_Edile
{
    public partial class Pagamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionSTR = ConfigurationManager.ConnectionStrings["ConnectionStrDB"].ConnectionString.ToString();
            SqlConnection connection = new SqlConnection(connectionSTR);

            try
            {
                string tipoPagamento;
                tipoPagamento = DropDownList1.DataValueField;
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "insert into Pagamenti values(@DataPagamento,@AmmontarePagamento,@StipendioAcconto,@IDdipendente)";
                cmd.Parameters.AddWithValue("DataPagamento", DateTime.Now);
                cmd.Parameters.AddWithValue("AmmontarePagamento", Convert.ToDouble(TextAmmontare.Text));
                cmd.Parameters.AddWithValue("StipendioAcconto", tipoPagamento);
                cmd.Parameters.AddWithValue("IDdipendente", TextIDdipendente.Text);
                int inserimentoEffettuato = cmd.ExecuteNonQuery();
                if (inserimentoEffettuato > 0)
                {
                    Response.Write("Nuovo pagamento effettuato con successo con sucesso");
                }

            }
            catch (Exception ex) { Response.Write(ex); }
            finally { connection.Close(); }
        }
    }
}