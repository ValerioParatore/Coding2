using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spedizioni.Models
{
    public class Utente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string CodiceFiscale { get; set; }
        
        public string Residenza { get; set; }
        public string Citta {  get; set; }

    }
}