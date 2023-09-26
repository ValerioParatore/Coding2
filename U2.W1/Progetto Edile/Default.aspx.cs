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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionSTR = ConfigurationManager.ConnectionStrings["ConnectionStrDB"].ConnectionString.ToString();
            SqlConnection connection = new SqlConnection(connectionSTR);

            List<Dipendente> dipendentiList = new List<Dipendente>();

            SqlCommand cmd = new SqlCommand("select * from Dipendenti", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Dipendente dip = new Dipendente(Convert.ToInt32(reader["IDdipendente"]), reader["Nome"].ToString(), reader["Cognome"].ToString(),
                    reader["CodiceFiscale"].ToString(), Convert.ToBoolean(reader["Sposato"]), Convert.ToInt32(reader["Nfigli"]),
                    reader["Mansione"].ToString(), reader["Indirizzo"].ToString());
                dipendentiList.Add(dip);
            }
            GridView1.DataSource = dipendentiList;
            GridView1.DataBind();
            connection.Close();
        }
    }
    public class Dipendente
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public int id { get; set; } 
        public string cd { get; set; }
        public static bool sposato { get; set; }   
        public int nFigli { get; set; }
        public string mansione { get; set; }
        public string indirizzo { get; set; }

        public Dipendente(int idDip, string nomeDip, string cognomeDip, string cdDip, bool coniugato , int nFigliDip, string mansioneDip, string indirizzoDip) 
        {
            id = idDip;
            nome = nomeDip;
            cognome = cognomeDip;
            cd = cdDip;
            sposato = coniugato;
            nFigli = nFigliDip;
            mansione = mansioneDip;
            indirizzo = indirizzoDip;
        }
    }
}