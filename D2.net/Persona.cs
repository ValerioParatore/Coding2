using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace D2.net
{
    public class Persona
    {
        private string nome { get; set; }
        private string cognome { get; set; }
        private int eta { get; set; }
        public Persona( string nome, string cognome, int eta) 
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
        }


        public string GetName()
        {
            return nome;
        }
        public string GetCognome ()
        {
            return cognome;
        }
        public int Geteta()
        {
            return eta;
        }
        public string GetDetail()
        {
            return nome + cognome + eta;
        }

    }
}
