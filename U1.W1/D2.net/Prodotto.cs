using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2.net
{

    public class Prodotto
    {
        private string nomeProdotto { get; set; }
        private int prezzoProdotto { get; set; }
        private int quantitaProdotto { get; set; }
        public Prodotto(string n, int p, int q) 
        {
        this.nomeProdotto = n;
        this.prezzoProdotto = p;
        this.quantitaProdotto = q;
        }
        public int calcolaTot() 
        {
        return quantitaProdotto * prezzoProdotto;
        }

    }
}
