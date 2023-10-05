using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spedizioni.Models
{
    public class Spedizione
    {
        public int idSpedizione {  get; set; }
        public string NomeDestinatario { get; set; }
        public double Costo { get; set; }
        public DateTime dataStimaConsegna { get; set; }
        public string IndirizzoDestinatario { get;set; }
        public double pesoKg { get; set; }
        public string cittaDestinatario { get; set; }
        public DateTime dataSpedizione { get; set; }


        public int codiceSpedizione { get;set; }
        public int idCliente { get; set; }
        public int idStato { get; set; }

        public string NomeCliente { get; set; }
        public string NomeAzienda { get; set; }
        public string CodiceFiscale { get; set; }
        public string PartitaIVA { get; set; }
        
    }
}