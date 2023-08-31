using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    public class Numeri
    {
        public Numeri() { }
        public int number(int n) 
        {
            int[] number = new int[n];
            int total = 0;
            foreach (int i in number)
            {
                total += i;
            }
            return total; 
        }
    }
}
