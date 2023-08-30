using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContoCorrenteEsercizio
{

    public class ContoCorrente
    {
        public ContoCorrente() { }
        public string Name { get; set; }
        public string Cognome { get; set; }
        public int conto { get; set; }
        public decimal versamento(int q)
        {
            return conto += q;
        }
        public decimal prelievo(int q)
        {
            return conto -= q;
        }
        public void MenuStart1()
        {
            Console.WriteLine("Apri il tuo contocorrente ");
            Console.WriteLine("1. Inserisci il tuo nome");
            Console.WriteLine("2. Esci");
            int scelta = int.Parse(Console.ReadLine());

            if (scelta == 1)
            {
                apriNuovoConto();
            }
            else if (scelta == 2)
            {
                Console.WriteLine("Chiusura programma in corso");
            }


        }
        public void Menu2()
        {
            Console.WriteLine("Benevenuto " + Name + " " + Cognome);
            Console.WriteLine("Il tuo saldo attuale e' di :" + conto + " Euro");
            Console.WriteLine("1. Cambia Nome");
            Console.WriteLine("2. Versamento ");
            Console.WriteLine("3. Prelievo");
            Console.WriteLine("4. Esci");
            int scelta = int.Parse(Console.ReadLine());

            if (scelta == 1)
            {
                apriNuovoConto();
            }
            else if (scelta == 2)
            {
                avviaVersamento();
            }
            else if (scelta == 3)
            {
                avviaPrelievo();
            }
            else if (scelta == 4)
            {
                Console.WriteLine("Chiusura programma in corso");
            }

        }
        public void apriNuovoConto() 
        {
            Console.WriteLine("Inserisci il tuo nome");
            Name = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome");
            Cognome = Console.ReadLine();
            Menu2();
        }
        public void avviaVersamento()
        {
            Console.WriteLine("Quanto vuoi versare?");
            int q = int.Parse(Console.ReadLine());
            versamento(q);
            Menu2();
        }
        public void avviaPrelievo()
        {
            Console.WriteLine("Quanto vuoi prelevare?");
            int q = int.Parse(Console.ReadLine());
            prelievo(q);
            Menu2();
        }
    }
}
