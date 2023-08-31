using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3.net
{
    public class CV
    {
        public InforPersonali infoPersonali { get; set; }
        public List<Studi> studi { get; set; }    
        public List<Impiego> impieghi { get; set; }    
        
    }
    public class InforPersonali
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public int tel { get; set; }
        public string email { get; set; }
    }
    public class Studi
    {
        public string qualifica { get; set; }
        public string istituto { get; set; }
        public string tipo { get; set; }
        public string data { get; set; }
    }
    public class Impiego
    {
        public Esperienza esperienza { get; set; }
    }
    public class Esperienza
    {
        public string azienda { get; set; }
        public string jobTitle { get; set; }
        public string data { get; set; }
        public string descrizione { get; set; }
        public string compiti { get; set; } 

    }
}
