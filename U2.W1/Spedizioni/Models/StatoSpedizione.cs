using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spedizioni.Models
{
    public class StatoSpedizione
    {
        public string statoSpedizione { get; set; }
        public string descrizione { get; set; }
        public int idSpedizione { get; set; }
        public string citta { get; set; }
    }
}