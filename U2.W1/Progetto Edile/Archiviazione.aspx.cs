using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Progetto_Edile
{
    public partial class Archiviazione : System.Web.UI.Page
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
                
                if(CheckBoxFigli.Checked)
                {
                    Dipendente.sposato = true;
                }
                else
                {
                    Dipendente.sposato = false;
                }
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "insert into Dipendenti values(@Nome,@Cognome,@Indirizzo,@CodiceFiscale,@Sposato,@Nfigli,@Mansione)";
                cmd.Parameters.AddWithValue("Nome", TextNome.Text);
                cmd.Parameters.AddWithValue("Cognome", TextCognome.Text);
                cmd.Parameters.AddWithValue("CodiceFiscale", TextCD.Text);
                cmd.Parameters.AddWithValue("Sposato", Dipendente.sposato);
                cmd.Parameters.AddWithValue("Nfigli", Convert.ToInt32(TextNfigli.Text));
                cmd.Parameters.AddWithValue("Mansione", MansioneList.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("Indirizzo", TextIndirizzo.Text);
                int inserimentoEffettuato = cmd.ExecuteNonQuery();
                if(inserimentoEffettuato > 0)
                {
                    Response.Write("Nuovo dipendente aggiunto con sucesso");
                }

            }
            catch (Exception ex) { Response.Write(ex); }
            finally { connection.Close(); }
        }
    }
}