using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_scarpe.Models
{
    public class Scarpe
    {
        public int Id { get; set; }
        [Display(Name = "Nome prodotto")]
        public string nomeScarpa { get; set; }
        [Display(Name = "Prezzo prodotto")]
        public double   prezzoScarpa { get; set; }
        [Display(Name = "Descrizione prodotto")]
        public string descrizioneScarpa { get; set; }
        [Display(Name = "Immagine di copertina")]
        public string imgCopertina { get; set; }
        [Display(Name = "Immagine secondaria")]
        public string imgN2 { get; set; }
        [Display(Name = "Immagine terziaria")]
        public string imgN3 { get; set; }
        public Scarpe() { }
        public Scarpe(int id, string nome, double prezzo, string descrizione, string imgCop, string img2, string img3) 
        {
            this.Id = id;
            this.nomeScarpa = nome;
            this.prezzoScarpa = prezzo;
            this.imgCopertina = imgCop;
            this.imgN2 = img2;
            this.imgN3 = img3;
        }

        
    }
}