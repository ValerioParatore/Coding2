using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{

    public class Nomi
    {
        public Nomi() { }
        string[] nomi = new string[10];

        public void StartMenu () 
        {

            Console.WriteLine("1. Inserisci 10 nuovi nomi!");
            Console.WriteLine("2. Vuoi cercare un nome?");

            int scelta = int.Parse(Console.ReadLine());

            if (scelta == 1)
            {
                addName();
            }else if (scelta == 2)
            {
                searchName();
            }
            

        }
        public void searchName()
        {
            Console.WriteLine("Vuoi cercare un nome?");
            string name = Console.ReadLine();
            foreach (var item in nomi)
            {
                if (item == name)
                {
                    Console.WriteLine("Nome trovat! " + name);
                    StartMenu();
                }else
                {
                    Console.WriteLine("Nome non trovato");
                    StartMenu();
                }
            }
            StartMenu();
        }
        public void addName ()
        {
            for (int i = 0; i < nomi.Length; i++)
            {
                Console.WriteLine("Inserisci nome");
                nomi[i] = Console.ReadLine();
            }
            StartMenu();
        }

    }
}
