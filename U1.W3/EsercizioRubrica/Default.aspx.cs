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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionSTR = ConfigurationManager.ConnectionStrings["ConnectionStrDB"].ConnectionString.ToString();
            SqlConnection connection = new SqlConnection(connectionSTR);

            SqlCommand cmd = new SqlCommand("select * from rubricaEpicode", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

     

            List<Utente> utenti = new List<Utente>();
            
            while (reader.Read()) 
            {
                Utente utent = new Utente();
                utent.IDutente = Convert.ToInt32(reader["IDutente"]);
                utent.nome = reader["nome"].ToString();
                utent.cognome = reader["cognome"].ToString();
                utent.indirizzo = reader["indirizzo"].ToString();
                utent.email = reader["email"].ToString();
                utent.telefono = reader["telefono"].ToString();
                utent.foto = reader["foto"].ToString();
                utenti.Add(utent);
            }
            Repeater1.DataSource = utenti;
            Repeater1.DataBind();
            connection.Close();
        }
    }
    public class Utente
    {
        public int IDutente { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public string indirizzo { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string foto { get; set; }
    }
}