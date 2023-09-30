﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgettoSettimanalePOLIZIA.Models
{
    public class Verbali
    {
        public int IDVerbale { get; set; }
        public DateTime DataViolazione { get; set; }
        public string IndirizzoViolazione { get;set; }
        public string Nominativo_Agente { get; set; }
        public DateTime DataTrascrizioneVerbale { get; set; }
        public double Importo { get; set; }
        public int DecurtamentoPunti { get; set; }
        public int IDViolazione { get; set ; }
        public int IDAnagrafica { get; set; }
        

    }
}