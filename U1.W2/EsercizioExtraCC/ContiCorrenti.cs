using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioExtraCC
{

    public class ContiCorrenti
    {
        public string NomeCorrentista { get; set; }
        public string CognomeCorentista { get; set; }
        public DateTime DataDiApertura = DateTime.Now;
        public int NumeroDiConto { get; set; }
        public double SaldoConto { get; set; }
        public string MovimentoSaldo { get; set; }
        public double cifra { get; set; }
        public static int numeroContoC = 4;
        public ContiCorrenti() { }
        public ContiCorrenti(string nomeC, string cognomeC, DateTime dataApertura, int numeroC, double saldo)
        {
            NomeCorrentista = nomeC;
            CognomeCorentista = cognomeC;
            DataDiApertura = dataApertura;
            NumeroDiConto = numeroC;   
            SaldoConto = saldo;
        }
        public ContiCorrenti(int numeroConto, string movimento, double cifra)
        {
            NumeroDiConto = numeroConto;
            MovimentoSaldo = movimento;
            this.cifra = cifra;
        }
        public static List<ContiCorrenti> contiCorrenti = new List<ContiCorrenti>();
        public static List<ContiCorrenti> movimenti = new List<ContiCorrenti>();
        public static void menuStart()
        {
            contiCorrenti.Add(new ContiCorrenti("Mario","Rossi",DateTime.Now,1,0));
            contiCorrenti.Add(new ContiCorrenti("Irene", "Bianchi", DateTime.Now, 2, 0));
            contiCorrenti.Add(new ContiCorrenti("Giovanni", "Vasaio", DateTime.Now, 3, 0));
            contiCorrenti.Add(new ContiCorrenti("Silvio", "Berlusconi", DateTime.Now, 4, 0));


            while(true)
            {
                Console.WriteLine("===== Benvenuto nella gestione conti correnti.");
                Console.WriteLine("1) Apri Conto corrente.");
                Console.WriteLine("2) Effettua una operazione");
                Console.WriteLine("3) Stampa movimenti del cc.");
                Console.WriteLine("4) Stampa il saldo di tutti i cc.");
                Console.WriteLine("5) Esci");
                Console.Write("Digita un numero:");
                int scelta = int.Parse(Console.ReadLine());
                if (scelta ==1)
                {
                    nuovoConto();
                }else if(scelta ==2)
                {
                    saldoConto();
                }else if (scelta ==3)
                {
                    stampaMovimentiConto();
                }else if (scelta == 4)
                {
                    stampaSaldi();
                }else if (scelta == 5)
                {
                    Environment.Exit(0);
                }else
                {
                    Console.WriteLine("Scelta non valida");
                }
            }


        }
        public static void nuovoConto()
        {
            numeroContoC++;
            DateTime dateTime = DateTime.Now;
            Console.Write("Inserisci nome :");
            string nome = Console.ReadLine();
            Console.Write("Inserisci cognome : ");
            string cognome = Console.ReadLine();
            contiCorrenti.Add(new ContiCorrenti(nome, cognome, dateTime, numeroContoC, 0));
            
            Console.WriteLine("Nuovo Conto aperto correttamente");

        }

        public static void saldoConto()
        {
            Console.WriteLine("Digita il numero del conto corrente");
            int numeroConto = int.Parse(Console.ReadLine());
            Console.WriteLine("Che operazione vuoi fare?(versamento/prelievo)");
            string scelta = Console.ReadLine();
            if (scelta == "versamento")
            {
                Console.WriteLine("Quanto vuoi versare?");
                double versamento = double.Parse(Console.ReadLine()); 
                foreach (ContiCorrenti conti in contiCorrenti)
                {
                    if(conti.NumeroDiConto == numeroConto)
                    {
                        conti.SaldoConto += versamento;
                        movimenti.Add(new ContiCorrenti(conti.NumeroDiConto,"versamento",versamento));
                        Console.WriteLine("Versamento effettuato correttamente.");
                    }
                }
            }else if (scelta == "prelievo")
            {
                Console.WriteLine("Quanto vuoi prelevare?");
                double prelievo = double.Parse(Console.ReadLine());
                foreach (ContiCorrenti conti in contiCorrenti)
                {
                    if (conti.NumeroDiConto == numeroConto)
                    {
                        if(conti.SaldoConto >= prelievo)
                        {
                            conti.SaldoConto -= prelievo;
                            movimenti.Add(new ContiCorrenti(conti.NumeroDiConto,"prelievo",prelievo));
                            Console.WriteLine("Prelievo effettuato correttamente");
                        }
                        else
                        {
                            Console.WriteLine("Il saldo attuale e' inferiore alla richiesta di prelievo.");
                        }
                    }

                }
            }else
            {
                Console.WriteLine("Scelta non valida.");
            }
        }
        public static void stampaMovimentiConto()
        {
            Console.Write("Digita il numero del conto che vuoi cercare :");
            int nConto = int.Parse(Console.ReadLine());
            foreach(ContiCorrenti conto in movimenti)
            {
                if(conto.NumeroDiConto ==  nConto)
                {
                    Console.WriteLine($"Il conto corrente numero :{conto.NumeroDiConto} ha effettuato un {conto.MovimentoSaldo} di euro {conto.cifra}");
                }else
                {
                    Console.WriteLine("Numero di conto non valido.");
                }
            }

        }
        public static void stampaSaldi()
        {
            foreach(ContiCorrenti conto in contiCorrenti)
            {
                Console.WriteLine($"Il conto corrente numero :{conto.NumeroDiConto} possiede un saldo di: {conto.SaldoConto}");
            }
        }


    }
}
