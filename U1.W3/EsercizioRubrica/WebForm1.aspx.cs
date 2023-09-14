using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EsercizioRubrica
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fotoName = "";
            if (FileUpload1.HasFile)
            {
                fotoName = FileUpload1.FileName;
                FileUpload1.SaveAs(Server.MapPath($"/Content/imgs/{FileUpload1.FileName}"));
            }
            string connectionSTR = ConfigurationManager.ConnectionStrings["ConnectionStrDB"].ConnectionString.ToString();
            SqlConnection connection = new SqlConnection(connectionSTR);


            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "insert into rubricaEpicode values(@nome,@cognome,@indirizzo,@telefono,@foto,@email)";
                cmd.Parameters.AddWithValue("nome", TextNome.Text);
                cmd.Parameters.AddWithValue("cognome", TextCognome.Text);
                cmd.Parameters.AddWithValue("indirizzo", TextIndirizzo.Text);
                cmd.Parameters.AddWithValue("telefono", TextTelefono.Text);
                cmd.Parameters.AddWithValue("foto", fotoName);
                cmd.Parameters.AddWithValue("email", Textemail.Text);
                int inserimentoEffettuato = cmd.ExecuteNonQuery();

                if (inserimentoEffettuato > 0)
                {
                    Response.Write("Nuove utente aggiunto alla rubrica con successo");
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }
    }
}