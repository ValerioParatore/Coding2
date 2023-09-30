using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgettoSettimanalePOLIZIA.Models
{
    public class Anagrafe
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Inidirizzo { get; set; }
        public string Citta { get; set; }
        public string CAP { get; set; }
        public string CodiceFiscale { get; set; }

    }
}