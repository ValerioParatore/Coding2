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
    public partial class utenteSelezionato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectionSTR = ConfigurationManager.ConnectionStrings["ConnectionStrDB"].ConnectionString.ToString();
                SqlConnection connection = new SqlConnection(connectionSTR);
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from rubricaEpicode where IDutente=@id", connection);
                cmd.Parameters.AddWithValue("id", Request.QueryString["IDutente"]);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string nomeUtente = reader["nome"].ToString();
                    string cognomeUtente = reader["cognome"].ToString();
                    string indirizzoUtente = reader["indirizzo"].ToString();
                    string telefonoUtente = reader["telefono"].ToString();
                    string emailUtente = reader["email"].ToString();
                    string fotoUtente = reader["foto"].ToString() ;

                    TextNome.Text = nomeUtente;
                    TextCognome.Text = cognomeUtente;  
                    TextIndirizzo.Text = indirizzoUtente;
                    TextTelefono.Text = telefonoUtente;
                    TextEmail.Text = emailUtente;
                    Foto.Src = $"Content/imgs/{fotoUtente}";
                }
                connection.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionSTR = ConfigurationManager.ConnectionStrings["ConnectionStrDB"].ConnectionString.ToString();
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "update rubricaEpicode set nome=@nome,cognome=@cognome,indirizzo=@indirizzo,telefono=@telefono,email=@email where IDutente=@id";
            cmd.Parameters.AddWithValue("nome", TextNome.Text);
            cmd.Parameters.AddWithValue("cognome", TextCognome.Text);
            cmd.Parameters.AddWithValue("indirizzo", TextIndirizzo.Text);
            cmd.Parameters.AddWithValue("telefono", TextTelefono.Text);
            cmd.Parameters.AddWithValue("email", TextEmail.Text);
            cmd.Parameters.AddWithValue("id", Request.QueryString["IDutente"]);
            cmd.ExecuteNonQuery();
            connection.Close();
            Response.Redirect($"utenteSelezionato.aspx?IDutente={Request.QueryString["IDutente"]}");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connectionSTR = ConfigurationManager.ConnectionStrings["ConnectionStrDB"].ConnectionString.ToString();
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "delete from rubricaEpicode where IDutente=@id";
            cmd.Parameters.AddWithValue("id", Request.QueryString["IDutente"]);
            cmd.ExecuteNonQuery( );
            connection.Close( );
            Response.Redirect("Default.aspx");

        }
    }
}