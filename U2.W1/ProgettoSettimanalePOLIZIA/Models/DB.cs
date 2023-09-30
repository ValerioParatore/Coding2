using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ProgettoSettimanalePOLIZIA.Models
{
    public class DB
    {
        public static List<Anagrafe> getAllTrasgressori()
        {
            List<Anagrafe> listaTrasgressori = new List<Anagrafe>();

            string connection = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SELECT * FROM ANAGRAFICA", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(); 
            while (reader.Read())
            {
                Anagrafe persona = new Anagrafe(); 
                persona.ID = Convert.ToInt32(reader["IDAnagrafica"]);
                persona.Nome = reader["Nome"].ToString() ;
                persona.Cognome = reader["Cognome"].ToString();
                persona.Inidirizzo = reader["Indirizzo"].ToString();
                persona.Citta = reader["Citta"].ToString();
                persona.CAP = reader["CAP"].ToString();
                persona.CodiceFiscale = reader["Codice_Fiscale"].ToString();
                listaTrasgressori.Add(persona);

            }

            conn.Close();


            return listaTrasgressori;
        }


        public static Anagrafe getTrasPerID (int id)
        {
            Anagrafe personaID = new Anagrafe();  

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM ANAGRAFICA WHERE IDAnagrafica = '@id'", conn);
            cmd.Parameters.AddWithValue("id", id);  
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(); 
            while (reader.Read())
            {
                Anagrafe persona = new Anagrafe();

                persona.ID = Convert.ToInt32(reader["IDAnagrafica"]);
                persona.Nome = reader["Nome"].ToString();
                persona.Cognome = reader["Cognome"].ToString();
                persona.Inidirizzo = reader["Indirizzo"].ToString();
                persona.Citta = reader["Citta"].ToString();
                persona.CAP = reader["CAP"].ToString();
                persona.CodiceFiscale = reader["Codice_Fiscale"].ToString();
                personaID = persona;
            }
            conn.Close();

            return personaID;
        }

        public static void addTras(Anagrafe tras)
        {


            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO ANAGRAFICA VALUES(@Nome, @Cognome, @Indirizzo,@Citta,@CAP, @CodiceFiscale)", conn);
            
            cmd.Parameters.AddWithValue("Nome" , tras.Nome);
            cmd.Parameters.AddWithValue("Cognome", tras.Cognome);
            cmd.Parameters.AddWithValue("Indirizzo", tras.Inidirizzo);
            cmd.Parameters.AddWithValue("Citta", tras.Citta);
            cmd.Parameters.AddWithValue("CAP", tras.CAP);
            cmd.Parameters.AddWithValue("CodiceFiscale", tras.CodiceFiscale);
            int eseguito = cmd.ExecuteNonQuery();




            conn.Close();



        }


        public static List<Verbali> getAllVerbali()
        {
            List<Verbali> listaVerbali = new List<Verbali>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Verbale",conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(); 
            while (reader.Read())
            {
                Verbali verbale = new Verbali();

                verbale.IDVerbale = Convert.ToInt32(reader["IDVerbale"]);
                verbale.DataViolazione = Convert.ToDateTime(reader["DataViolazione"]);
                verbale.IndirizzoViolazione = reader["IndirizzoViolazione"].ToString() ;
                verbale.Nominativo_Agente = reader["Nominativo_Agente"].ToString();
                verbale.DataTrascrizioneVerbale = Convert.ToDateTime(reader["DataTrascrizioneVerbale"]);
                verbale.Importo = Convert.ToDouble(reader["Importo"]);
                verbale.DecurtamentoPunti = Convert.ToInt32(reader["DecurtamentoPunti"]);
                verbale.IDViolazione = Convert.ToInt32(reader["IDViolazione"]);
                verbale.IDAnagrafica = Convert.ToInt32(reader["IDAnagrafica"]);

                listaVerbali.Add(verbale);  
            }
            conn.Close();



            return listaVerbali;
        }

        public static List<Verbali> getVerbaliPerIDTras(int id)
        {
            List<Verbali> listaVerbali = new List<Verbali>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Verbale where IDAnagrafica='@id'", conn);
            cmd.Parameters.AddWithValue("id", id);
            
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Verbali verbale = new Verbali();

                verbale.IDVerbale = Convert.ToInt32(reader["IDVerbale"]);
                verbale.DataViolazione = Convert.ToDateTime(reader["DataViolazione"]);
                verbale.IndirizzoViolazione = reader["IndirizzoViolazione"].ToString();
                verbale.Nominativo_Agente = reader["Nominativo_Agente"].ToString();
                verbale.DataTrascrizioneVerbale = Convert.ToDateTime(reader["DataTrascrizioneVerbale"]);
                verbale.Importo = Convert.ToDouble(reader["Importo"]);
                verbale.DecurtamentoPunti = Convert.ToInt32(reader["DecurtamentoPunti"]);
                verbale.IDViolazione = Convert.ToInt32(reader["IDViolazione"]);
                verbale.IDAnagrafica = Convert.ToInt32(reader["IDAnagrafica"]);

                listaVerbali.Add(verbale);
            }
            conn.Close();



            return listaVerbali;
        }

        public static int totPuntiDec(int id)
        {
            List<Verbali> listaVerbali = new List<Verbali>();
            int totPunti = 0;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Verbale where IDAnagrafica='@id'", conn);
            cmd.Parameters.AddWithValue("id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Verbali verbale = new Verbali();

                verbale.IDVerbale = Convert.ToInt32(reader["IDVerbale"]);
                verbale.DataViolazione = Convert.ToDateTime(reader["DataViolazione"]);
                verbale.IndirizzoViolazione = reader["IndirizzoViolazione"].ToString();
                verbale.Nominativo_Agente = reader["Nominativo_Agente"].ToString();
                verbale.DataTrascrizioneVerbale = Convert.ToDateTime(reader["DataTrascrizioneVerbale"]);
                verbale.Importo = Convert.ToDouble(reader["Importo"]);
                verbale.DecurtamentoPunti = Convert.ToInt32(reader["DecurtamentoPunti"]);
                verbale.IDViolazione = Convert.ToInt32(reader["IDViolazione"]);
                verbale.IDAnagrafica = Convert.ToInt32(reader["IDAnagrafica"]);

                listaVerbali.Add(verbale);
            }
            conn.Close();
            foreach (Verbali verbale in listaVerbali)
            {
                totPunti += verbale.DecurtamentoPunti;
            }


            return totPunti;
        }


        public static List<Verbali> verbaliOver10P()
        {
            List<Verbali> listaVerbali = new List<Verbali>();
            List<Verbali> verbali10P = new List<Verbali>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Verbale", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Verbali verbale = new Verbali();

                verbale.IDVerbale = Convert.ToInt32(reader["IDVerbale"]);
                verbale.DataViolazione = Convert.ToDateTime(reader["DataViolazione"]);
                verbale.IndirizzoViolazione = reader["IndirizzoViolazione"].ToString();
                verbale.Nominativo_Agente = reader["Nominativo_Agente"].ToString();
                verbale.DataTrascrizioneVerbale = DateTime.Now ;//Convert.ToDateTime(reader["DataTrascrizioneVerbale"]);//
                verbale.Importo = Convert.ToDouble(reader["Importo"]);
                verbale.DecurtamentoPunti = Convert.ToInt32(reader["DecurtamentoPunti"]);
                verbale.IDViolazione = Convert.ToInt32(reader["IDViolazione"]);
                verbale.IDAnagrafica = Convert.ToInt32(reader["IDAnagrafica"]);

                listaVerbali.Add(verbale);
            }
            conn.Close();

            foreach (Verbali ver in listaVerbali)
            {
                if(ver.DecurtamentoPunti >= 10)
                {
                    verbali10P.Add(ver);
                }
            }

            return verbali10P;
        }

        public static List<Verbali> verbaliOver400()
        {
            List<Verbali> listaVerbali = new List<Verbali>();
            List<Verbali> verbaliOver400 = new List<Verbali>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Verbale", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Verbali verbale = new Verbali();

                verbale.IDVerbale = Convert.ToInt32(reader["IDVerbale"]);
                verbale.DataViolazione = Convert.ToDateTime(reader["DataViolazione"]);
                verbale.IndirizzoViolazione = reader["IndirizzoViolazione"].ToString();
                verbale.Nominativo_Agente = reader["Nominativo_Agente"].ToString();
                verbale.DataTrascrizioneVerbale =   DateTime.Now;                                 //Convert.ToDateTime(reader["DataTrascrizioneVerbale"]);//
                verbale.Importo = Convert.ToDouble(reader["Importo"]);
                verbale.DecurtamentoPunti = Convert.ToInt32(reader["DecurtamentoPunti"]);
                verbale.IDViolazione = Convert.ToInt32(reader["IDViolazione"]);
                verbale.IDAnagrafica = Convert.ToInt32(reader["IDAnagrafica"]);

                listaVerbali.Add(verbale);
            }
            conn.Close();

            foreach (Verbali ver in listaVerbali)
            {
                if (ver.Importo > 400)
                {
                    verbaliOver400.Add(ver);
                }
            }

            return verbaliOver400;
        }

        public static void addVerbale(Verbali tras)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Verbale VALUES(@DataViolazione, @IndirizzoViolazione, @Nominativo_Agente,@DataTrascrizioneVerbale,@Importo,@DecurtamentoPunti,@IDViolazione,@IDAnagrafica)", conn);
            
            cmd.Parameters.AddWithValue("DataViolazione", tras.DataViolazione);
            cmd.Parameters.AddWithValue("IndirizzoViolazione", tras.IndirizzoViolazione);
            cmd.Parameters.AddWithValue("Nominativo_Agente", tras.Nominativo_Agente);
            cmd.Parameters.AddWithValue("DataTrascrizioneVerbale", tras.DataTrascrizioneVerbale);
            cmd.Parameters.AddWithValue("Importo", tras.Importo);
            cmd.Parameters.AddWithValue("DecurtamentoPunti", tras.DecurtamentoPunti);
            cmd.Parameters.AddWithValue("IDViolazione", tras.IDViolazione);
            cmd.Parameters.AddWithValue("IDAnagrafica", tras.IDAnagrafica);
            int eseguito = cmd.ExecuteNonQuery();




            conn.Close();

        }

        public static List<TipoViolazioni> getAllTipiVio()
        {
            List<TipoViolazioni> listaVio = new List<TipoViolazioni> ();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT * from TIPO_VIOLAZIONE", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                TipoViolazioni tipoViolazione = new TipoViolazioni();

                tipoViolazione.IDViolazione = Convert.ToInt32(reader["IDViolazione"]);
                tipoViolazione.Descrizione = reader["Descrizione"].ToString();

                listaVio.Add(tipoViolazione);
            }

            conn.Close ();


            return listaVio;
        }

        public static void addTipoViolazione (TipoViolazioni tras)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TIPO_VIOLAZIONE VALUES(@Descrizione)", conn);
            
            cmd.Parameters.AddWithValue("Descrizione", tras.Descrizione);

            int eseguito = cmd.ExecuteNonQuery();




            conn.Close();
        }
    }
}