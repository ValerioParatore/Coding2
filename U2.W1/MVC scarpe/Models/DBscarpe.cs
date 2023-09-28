using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_scarpe.Models
{
    public class DBscarpe
    {



        public static void AddScarpa(Scarpe scp, HttpPostedFileBase imgCopertina, HttpPostedFileBase imgN2, HttpPostedFileBase imgN3)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Insert into Scarpe values(@Nome,@Prezzo,@Descrizione,@ImgCopertina,@ImgN2,@ImgN3)";
                cmd.Parameters.AddWithValue("Nome", scp.nomeScarpa);
                cmd.Parameters.AddWithValue("Prezzo", scp.prezzoScarpa);
                cmd.Parameters.AddWithValue("Descrizione", scp.descrizioneScarpa);
                cmd.Parameters.AddWithValue("ImgCopertina", imgCopertina.FileName);
                cmd.Parameters.AddWithValue("ImgN2", imgN2.FileName);
                cmd.Parameters.AddWithValue("ImgN3", imgN3.FileName);
                int IsOk = cmd.ExecuteNonQuery();

            }

            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public static Scarpe getScarpaById(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Scarpe where IDscarpa = @id", conn);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader sqlDataReader;

            conn.Open();

            Scarpe scarpa = new Scarpe();
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                scarpa.Id = Convert.ToInt32(sqlDataReader["IDscarpa"]);
                scarpa.prezzoScarpa = Convert.ToDouble(sqlDataReader["Prezzo"]);
                scarpa.nomeScarpa = sqlDataReader["Nome"].ToString();
                scarpa.descrizioneScarpa = sqlDataReader["Descrizione"].ToString();
                scarpa.imgCopertina = sqlDataReader["ImgCopertina"].ToString();
                scarpa.imgN2= sqlDataReader["ImgN2"].ToString();
                scarpa.imgN3 = sqlDataReader["ImgN3"].ToString();
                
            }

            conn.Close();
            return scarpa;
        }

        public static List<Scarpe> getAllScarpe()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Scarpe", conn);
            SqlDataReader sqlDataReader;

            conn.Open();

            List<Scarpe> scarpe = new List<Scarpe>();
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Scarpe scarpa = new Scarpe();
                scarpa.Id = Convert.ToInt32(sqlDataReader["IDscarpa"]);
                scarpa.prezzoScarpa = Convert.ToDouble(sqlDataReader["Prezzo"]);
                scarpa.nomeScarpa = sqlDataReader["Nome"].ToString();
                scarpa.descrizioneScarpa = sqlDataReader["Descrizione"].ToString();
                scarpa.imgCopertina = sqlDataReader["ImgCopertina"].ToString();
                scarpa.imgN2 = sqlDataReader["ImgN2"].ToString();
                scarpa.imgN3 = sqlDataReader["ImgN3"].ToString();
                scarpe.Add(scarpa);
            }

            conn.Close();
            return scarpe;
        }


        public static void UpdateScarpa(Scarpe scp, HttpPostedFileBase imgCopertina, HttpPostedFileBase imgN2, HttpPostedFileBase imgN3)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE Scarpe SET @Nome,@Prezzo,@Descrizione,@ImgCopertina,@ImgN2,@ImgN3 WHERE IdScarpa = @id";
                cmd.Parameters.AddWithValue("Nome", scp.nomeScarpa);
                cmd.Parameters.AddWithValue("Prezzo", scp.prezzoScarpa);
                cmd.Parameters.AddWithValue("Descrizione", scp.descrizioneScarpa);
                cmd.Parameters.AddWithValue("ImgCopertina", imgCopertina.FileName);
                cmd.Parameters.AddWithValue("ImgN2", imgN2.FileName);
                cmd.Parameters.AddWithValue("ImgN3", imgN3.FileName);
                int IsOk = cmd.ExecuteNonQuery();

            }

            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }
        public static void Remove(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM Scarpe where IDscarpa=@id";
            cmd.Parameters.AddWithValue("id", id);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}