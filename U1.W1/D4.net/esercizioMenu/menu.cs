using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace esercizioMenu
{

    public class Menu
    {
        public Menu() { }
        public double saldo { get; set; }
        public static List<string> Conto { get; set; }
        public void start()
        {
            Console.WriteLine("==============MENU==============");
            Console.WriteLine("1:  Coca Cola 150 ml (€ 2.50)");
            Console.WriteLine("2:  Insalata di pollo (€ 5.20)");
            Console.WriteLine("3:  Pizza Margherita (€ 10.00)");
            Console.WriteLine("4:  Pizza 4 Formaggi (€ 12.50)");
            Console.WriteLine("5:  Pz patatine fritte (€ 3.50)");
            Console.WriteLine("6:  Insalata di riso (€ 8.00)");
            Console.WriteLine("7:  Frutta di stagione (€ 5.00)");
            Console.WriteLine("8:  Pizza fritta (€ 5.00)");
            Console.WriteLine("9:  Piadina vegetariana (€ 6.00)");
            Console.WriteLine("10: Panino Hamburger (€ 7.90)");
            Console.WriteLine("11: Stampa conto finale e conferma");
            Console.WriteLine("==============MENU==============");
            int scelta = int.Parse(Console.ReadLine());

            if (scelta == 1 )
            {
                add1();
            }else if (scelta == 2 )
            {
                add2();
            }else if (scelta == 3 )
            {
                add3();
            }else if (scelta == 4 )
            {
                add4();
            }else if (scelta == 5 )
            {
                add5();
            }else if (scelta == 6 )
            {
                add6();
            }else if (scelta == 7)
            {
                add7();
            }else if(scelta == 8 )
            {
                add8();
            }else if (scelta == 9)
            {
                add9();
            }else if (scelta == 10)
            {
                add10();
            }else if (scelta== 11)
            {
                stampaMenu();
            }
            else
            {
                Console.WriteLine("Comando non valido");
                start();
            }
            
        }
        public void add1()
        {
            this.saldo=+ 2.50;
            Conto.Add("Coca Cola 150 ml (€ 2.50)");
            Console.WriteLine("Coca Cola aggiunta al conto.");
            start();
        }
        public void add2()
        {
            saldo = +5.20;
            Conto.Add("Insalata di pollo (€ 5.20)");
            Console.WriteLine("Insalata di pollo aggiunta a conto");
            start();
        }
        public void add3()
        {
            saldo = +10.00;
            Conto.Add("Pizza Margherita (€ 10.00)");
            Console.WriteLine("Margherita aggiunta al conto");
            start();
        }
        public void add4()
        {
            saldo = +12.50;
            Conto.Add("Pizza 4 Formaggi (€ 12.50)");
            Console.WriteLine("4 formaggi aggiunta al conto");
            start();
        }
        public void add5()
        {
            saldo = +3.50;
            Conto.Add("Pz patatine fritte (€ 3.50)");
            Console.WriteLine("patatine aggiunte al conto");
            start();
        }
        public void add6()
        {
            saldo = +8.00;
            Conto.Add("Insalata di riso (€ 8.00)");
            Console.WriteLine("Insalata di riso aggiunta al conto");
            start();
        }
        public void add7()
        {
            Conto.Add("Frutta di stagione (€ 5.00)");
            Console.WriteLine("frutta aggiunta al conto");
            start();
        }
        public void add8()
        {
            saldo = +5.00;
            Conto.Add("Pizza fritta (€ 5.00)");
            Console.WriteLine("pizza fritta aggiunta al conto");
            start();
        }
        public void add9()
        {
            saldo = +6.00;
            Conto.Add("Piadina vegetariana (€ 6.00)");
            Console.WriteLine("Piadina veg aggiunta al conto");
            start();
        }
        public void add10()
        {
            saldo = +7.90;
            Conto.Add(" Panino Hamburger (€ 7.90)");
            Console.WriteLine("hamburger aggiunto al conto");
            start();
        }
        public void stampaMenu()
        {
            foreach(string i in Conto)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(saldo);
        }
    }
}
