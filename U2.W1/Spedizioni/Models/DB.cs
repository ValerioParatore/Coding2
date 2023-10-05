using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Spedizioni.Models
{
    public class DB
    {
        public static List<Aziende> getAllAziende()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open ();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Clienti WHERE PartitaIVA IS NOT NULL ",conn);
            List<Aziende> aziende = new List<Aziende>();
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Aziende azienda = new Aziende();   
                azienda.NomeAzienda = sqlDataReader["NomeAzienda"].ToString ();
                azienda.IndirizzoSede = sqlDataReader["IndirizzoSede"].ToString () ;
                azienda.cittaSede = sqlDataReader["CittaSede"].ToString();
                azienda.PartitaIVA= sqlDataReader["PartitaIVA"].ToString() ;
                aziende.Add(azienda);

            }
            conn.Close ();  
            return aziende;
        }
        public static void addAzienda(Aziende u)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Clienti(NomeAzienda,PartitaIVA,CittaSede,IndirizzoSede) values(@NomeAzienda,@PartitaIVA,@CittaSede,@IndirizzoSede)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("NomeAzienda", u.NomeAzienda);
                cmd.Parameters.AddWithValue("PartitaIVA", u.PartitaIVA);
                cmd.Parameters.AddWithValue("CittaSede", u.cittaSede);
                cmd.Parameters.AddWithValue("IndirizzoSede", u.IndirizzoSede);
                int ex = cmd.ExecuteNonQuery();

            }
            catch 
            {


            }
            finally
            {
                conn.Close();
            }
        }

        public static List<Utente> getAllUtenti()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Clienti WHERE CodiceFiscale IS NOT NULL", conn);
            conn.Open ();
            List<Utente> privati = new List<Utente>();
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Utente utente = new Utente();
                utente.Nome = sqlDataReader["Nome"].ToString();
                utente.Cognome = sqlDataReader["Cognome"].ToString();
                utente.CodiceFiscale = sqlDataReader["CodiceFiscale"].ToString();
                utente.DataNascita = Convert.ToDateTime(sqlDataReader["DataNascita"]);
                utente.Residenza = sqlDataReader["Residenza"].ToString();
                privati.Add(utente);    
               
            }
            conn.Close ();
            return privati;
        }
        public static void addUtente(Utente u )
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Clienti(Nome,Cognome,Citta,Residenza,DataNascita,CodiceFiscale) values(@Nome,@Cognome,@Citta,@Residenza,@DataNascita,@CodiceFiscale)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("Nome", u.Nome);
                cmd.Parameters.AddWithValue("Cognome", u.Cognome);
                cmd.Parameters.AddWithValue("Citta", u.Citta);
                cmd.Parameters.AddWithValue("Residenza", u.Residenza);
                cmd.Parameters.AddWithValue("DataNascita", u.DataNascita);
                cmd.Parameters.AddWithValue("CodiceFiscale", u.CodiceFiscale);
                int ex = cmd.ExecuteNonQuery();
                
            }catch 
            {


            }finally
            {
                conn.Close();
            }
        }
        public static List<Spedizione> getAllSpedizioni ()
        {
            List<Spedizione> spedizioniList = new List<Spedizione>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Spedizione", conn);
            conn.Open ();
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Spedizione shipping = new Spedizione();
                shipping.Costo = Convert.ToDouble(sqlDataReader["Costo"]);
                shipping.pesoKg = Convert.ToDouble(sqlDataReader["Peso"]);
                shipping.IndirizzoDestinatario = sqlDataReader["IndirizzoDestinazione"].ToString();
                shipping.NomeDestinatario = sqlDataReader["NomeDestinatario"].ToString();
                shipping.cittaDestinatario = sqlDataReader["CittaDestinazione"].ToString() ;
                
                shipping.dataSpedizione = Convert.ToDateTime( sqlDataReader["DataSpedizione"]);
                shipping.dataStimaConsegna = Convert.ToDateTime(sqlDataReader["DataConsegna"]);
                shipping.codiceSpedizione = Convert.ToInt16(sqlDataReader["CodiceSpedizione"]);
                shipping.idCliente = Convert.ToInt16(sqlDataReader["IDcliente"]);
                

                spedizioniList.Add( shipping );

            }
            conn.Close();
            return spedizioniList;
        }
        public static Spedizione getSpedizioneById (int id)
        {

            Spedizione shipping = new Spedizione();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Spedizione where IDspedizione = @IDspedizione", conn);
            cmd.Parameters.AddWithValue( "IDspedizione", id );
            conn.Open();
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                
                shipping.Costo = Convert.ToDouble(sqlDataReader["Costo"]);
                shipping.pesoKg = Convert.ToDouble(sqlDataReader["Peso"]);
                shipping.IndirizzoDestinatario = sqlDataReader["IndirizzoDestinazione"].ToString();
                shipping.NomeDestinatario = sqlDataReader["NomeDestinatario"].ToString();
                shipping.cittaDestinatario = sqlDataReader["CittaDestinazione"].ToString();
                
                shipping.dataSpedizione = Convert.ToDateTime(sqlDataReader["DataSpedizione"]);
                shipping.dataStimaConsegna = Convert.ToDateTime(sqlDataReader["DataConsegna"]);
                shipping.codiceSpedizione = Convert.ToInt16(sqlDataReader["CodiceSpedizione"]);
                shipping.idCliente = Convert.ToInt16(sqlDataReader["IDcliente"]);
                

                

            }

            conn.Close();

            return shipping;
        }
        public static Spedizione getSpedizioneByCD(string cd)
        {

            Spedizione shipping = new Spedizione();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Spedizione where CodiceFiscale = @CodiceFiscale", conn);
            cmd.Parameters.AddWithValue("CodiceFiscale", cd);
            conn.Open();
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {

                shipping.Costo = Convert.ToDouble(sqlDataReader["Costo"]);
                shipping.pesoKg = Convert.ToDouble(sqlDataReader["Peso"]);
                shipping.IndirizzoDestinatario = sqlDataReader["IndirizzoDestinazione"].ToString();
                shipping.NomeDestinatario = sqlDataReader["NomeDestinatario"].ToString();
                shipping.cittaDestinatario = sqlDataReader["CittaDestinazione"].ToString();
                
                shipping.dataSpedizione = Convert.ToDateTime(sqlDataReader["DataSpedizione"]);
                shipping.dataStimaConsegna = Convert.ToDateTime(sqlDataReader["DataConsegna"]);
                shipping.codiceSpedizione = Convert.ToInt16(sqlDataReader["CodiceSpedizione"]);
                shipping.idCliente = Convert.ToInt16(sqlDataReader["IDcliente"]);
                



            }

            conn.Close();

            return shipping;
        }


        public static Spedizione getSpedizioneByPIVA(string iva)
        {

            Spedizione shipping = new Spedizione();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Spedizione where PartitaIVA = @PartitaIVA", conn);
            cmd.Parameters.AddWithValue("PartitaIVA",iva);
            conn.Open();
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {

                shipping.Costo = Convert.ToDouble(sqlDataReader["Costo"]);
                shipping.pesoKg = Convert.ToDouble(sqlDataReader["Peso"]);
                shipping.IndirizzoDestinatario = sqlDataReader["IndirizzoDestinazione"].ToString();
                shipping.NomeDestinatario = sqlDataReader["NomeDestinatario"].ToString();
                shipping.cittaDestinatario = sqlDataReader["CittaDestinazione"].ToString();
               
                shipping.dataSpedizione = Convert.ToDateTime(sqlDataReader["DataSpedizione"]);
                shipping.dataStimaConsegna = Convert.ToDateTime(sqlDataReader["DataConsegna"]);
                shipping.codiceSpedizione = Convert.ToInt16(sqlDataReader["CodiceSpedizione"]);
                shipping.idCliente = Convert.ToInt16(sqlDataReader["IDcliente"]);
                



            }


            conn.Close();
            return shipping;
        }
        public static List<Spedizione> getAllClientiSpedizioni()
        {

           List<Spedizione> listShipping = new List<Spedizione>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT IDspedizione,CodiceSpedizione,NomeDestinatario,Costo,Peso,DataConsegna,IndirizzoDestinazione" +
                ",CittaDestinazione,DataSpedizione,Nome,Cognome,CodiceFiscale,PartitaIVA,NomeAzienda,PartitaIVA" +
                " FROM Spedizione left join Clienti on Spedizione.idClienti = Clienti.IDclienti", conn);
            
            conn.Open();
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Spedizione shipping = new Spedizione();
                shipping.idSpedizione = Convert.ToInt32(sqlDataReader["IDspedizione"]);
                shipping.Costo = Convert.ToDouble(sqlDataReader["Costo"]);
                shipping.pesoKg = Convert.ToDouble(sqlDataReader["Peso"]);
                shipping.IndirizzoDestinatario = sqlDataReader["IndirizzoDestinazione"].ToString();
                shipping.NomeDestinatario = sqlDataReader["NomeDestinatario"].ToString();
                shipping.cittaDestinatario = sqlDataReader["CittaDestinazione"].ToString();
                
                shipping.dataSpedizione = Convert.ToDateTime(sqlDataReader["DataSpedizione"]);
                shipping.dataStimaConsegna = Convert.ToDateTime(sqlDataReader["DataConsegna"]);
                shipping.codiceSpedizione = Convert.ToInt32(sqlDataReader["CodiceSpedizione"]);
                
                
                shipping.NomeCliente = sqlDataReader["Nome"].ToString();
                shipping.NomeAzienda = sqlDataReader["NomeAzienda"].ToString();
                shipping.CodiceFiscale = sqlDataReader["CodiceFiscale"].ToString();
                shipping.PartitaIVA = sqlDataReader["PartitaIVA"].ToString();

                listShipping.Add(shipping); 
            }


            conn.Close();
            return listShipping;
        }

        public static Spedizione getClienteSpedizione(int id)
        {

            Spedizione shipping = new Spedizione();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT CodiceSpedizione,NomeDestinatario,Costo,Peso,DataConsegna,IndirizzoDestinazione" +
                ",CittaDestinazione,DataSpedizione,Nome,Cognome,CodiceFiscale,PartitaIVA,NomeAzienda" +
                " FROM Spedizione left join Clienti on Spedizione.idClienti = Clienti.IDclienti where IDspedizione = @IDspedizione", conn);
            cmd.Parameters.AddWithValue("IDspedizione", id);
            conn.Open();
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                
                shipping.Costo = Convert.ToDouble(sqlDataReader["Costo"]);
                shipping.pesoKg = Convert.ToDouble(sqlDataReader["Peso"]);
                shipping.IndirizzoDestinatario = sqlDataReader["IndirizzoDestinazione"].ToString();
                shipping.NomeDestinatario = sqlDataReader["NomeDestinatario"].ToString();
                shipping.cittaDestinatario = sqlDataReader["CittaDestinazione"].ToString();
                
                shipping.dataSpedizione = Convert.ToDateTime(sqlDataReader["DataSpedizione"]);
                shipping.dataStimaConsegna = Convert.ToDateTime(sqlDataReader["DataConsegna"]);
                shipping.codiceSpedizione = Convert.ToInt32(sqlDataReader["CodiceSpedizione"]);
                
                
                shipping.NomeCliente = sqlDataReader["Nome"].ToString();
                shipping.NomeAzienda = sqlDataReader["NomeAzienda"].ToString();
                shipping.CodiceFiscale = sqlDataReader["CodiceFiscale"].ToString();
                shipping.PartitaIVA = sqlDataReader["PartitaIVA"].ToString();


            }


            conn.Close();
            return shipping;
        }


        public static List<StatoSpedizione> getStatoPerID(int id)
        {
            List<StatoSpedizione> listaStat   =    new List<StatoSpedizione>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM StatoSpedizione WHERE IDspedizione = @IDspedizione",conn);
            cmd.Parameters.AddWithValue("IDpspedizione", id);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                StatoSpedizione stat = new StatoSpedizione();

                stat.citta = reader["Citta"].ToString();
                stat.descrizione = reader["Descrizione"].ToString() ;
                stat.statoSpedizione = reader["Stato"].ToString();
                
            }


            conn.Close();

            return listaStat;
        }
        public static void addStatoSpedizione(StatoSpedizione st)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO StatoSpedizione(Stato,Descrizione,IDspedizione,Citta) valuse(@Stato,@Descrizione,@IDspedizione,@Citta)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("Stato", st.statoSpedizione);
                cmd.Parameters.AddWithValue("Descrizione", st.descrizione);
                cmd.Parameters.AddWithValue("IDspedizione", st.idSpedizione);
                cmd.Parameters.AddWithValue("Citta", st.citta);
                int ex = cmd.ExecuteNonQuery();
            }
            catch
            {

            }finally { conn.Close(); }
        }
        public static bool isAdmin (Admin admin)
        {
            Admin admin1 = new Admin();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Admins WHERE Username =@Username and PasswordUtente = @PasswordUtente", conn);
            cmd.Parameters.AddWithValue("Username",admin.Username);
            cmd.Parameters.AddWithValue("PasswordUtente",admin.Password);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
            
        }
        public static void addSpedizione (Spedizione sp)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString());
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Spedizione(CodiceSpedizione,NomeDestinatario,Costo,Peso,DataConsegna,IndirizzoDestinazione," +
                    "CittaDestinazione,DataSpedizione,idClienti) " +
                    "values(@CodiceSpedizione,@NomeDestinatario,@Costo,@Peso" +
                    ",@DataConsegna,@IndirizzoDestinazione,@CittaDestinazione,@DataSpedizione,@idClienti)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("CodiceSpedizione", sp.codiceSpedizione);
                cmd.Parameters.AddWithValue("NomeDestinatario", sp.NomeDestinatario);
                cmd.Parameters.AddWithValue("Costo", sp.Costo);
                cmd.Parameters.AddWithValue("Peso", sp.pesoKg);
                cmd.Parameters.AddWithValue("DataConsegna", sp.dataStimaConsegna);
                cmd.Parameters.AddWithValue("IndirizzoDestinazione", sp.IndirizzoDestinatario);
                cmd.Parameters.AddWithValue("CittaDestinazione", sp.cittaDestinatario);
                cmd.Parameters.AddWithValue("DataSpedizione", sp.dataSpedizione);
                cmd.Parameters.AddWithValue("idClienti", sp.idCliente);
                int ex = cmd.ExecuteNonQuery();
            }
            catch
            {

            }finally { conn.Close(); }

        }

    }
}