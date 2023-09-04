using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Contribuente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime dataDiNascita { get; set; }
        public string codiceFiscale { get; set; }
        public string sesso { get; set; }
        public string comune { get; set; }

        public double redditoAnnuo { get; set; }
        
        public Contribuente() { }
        public Contribuente(string Nome, string Cognome, DateTime dataDiNascita, string codiceFiscale, string sesso, string comuneDiResidenza, double redditoAnnuo) 
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.dataDiNascita = dataDiNascita;
            this.codiceFiscale = codiceFiscale;
            this.sesso = sesso;
            this.comune = comuneDiResidenza;
            this.redditoAnnuo = redditoAnnuo;
        }
        static double calcoloAliquotaImposta(double redditoAnnuo)
        {
            double aliquotaImposta = 0;
            if(redditoAnnuo <= 15000)
            {
                 aliquotaImposta = redditoAnnuo * 0.23;
            }
            else if(redditoAnnuo > 15000 &&  redditoAnnuo <= 28000)
            {
                aliquotaImposta = 3450 + (redditoAnnuo - 15000) * 0.27;
            }else if(redditoAnnuo >28000 &&  redditoAnnuo <= 55000)
            {
                aliquotaImposta = 6960 + (redditoAnnuo - 28000) * 0.38;
            }else if (redditoAnnuo >55000 &&  redditoAnnuo <= 75000)
            {
                aliquotaImposta = 17220 + (redditoAnnuo - 55000) * 0.41;
            }else if(redditoAnnuo > 75000 )
            {
                aliquotaImposta = 25420 + (redditoAnnuo - 75000) * 043;
            }
            return aliquotaImposta;
        }

        public static void Start()
        {
            List<Contribuente> contribuenti = new List<Contribuente>();

            while (true)
            {
                Console.WriteLine("====== Agenzia delle Entrate ======");
                Console.WriteLine("1) Inserisci una nuova dichiarazione dei redditi");
                Console.WriteLine("2) Vedi la lista di tutti i contribuenti");
                Console.WriteLine("3) Esci.");
                Console.Write("Scelta: ");
                string scelta = Console.ReadLine();
                Console.WriteLine();

                if (scelta == "1")
                {
                    Console.Write("Inserisci il nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Inserisci il cognome: ");
                    string cognome = Console.ReadLine();
                    Console.Write("Inserisci la data di nascita (DD/MM/YYYY): ");
                    DateTime dataDiNascita = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                    Console.Write("Inserisci il codice fiscale: ");
                    string codiceFiscale = Console.ReadLine();
                    Console.Write("Inserisci il sesso (M/F): ");
                    string sesso = Console.ReadLine();
                    Console.Write("Inserisci il comune di residenza: ");
                    string comuneResidenza = Console.ReadLine();
                    Console.Write("Inserisci il reddito annuale: ");
                    double redditoAnnuale = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Contribuente contribuente = new Contribuente(nome, cognome, dataDiNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);
                    contribuenti.Add(contribuente);

                    double imposta = calcoloAliquotaImposta(redditoAnnuale);

                    Console.WriteLine("==============================");
                    Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:");
                    Console.WriteLine($"Contribuente: {contribuente.Nome} {contribuente.Cognome},");
                    Console.WriteLine($"Nato/a il {contribuente.dataDiNascita:dd/MM/yyyy} ({contribuente.sesso}),");
                    Console.WriteLine($"Residente in {contribuente.comune},");
                    Console.WriteLine($"C.F.: {contribuente.codiceFiscale}");
                    Console.WriteLine($"Reddito dichiarato: € {contribuente.redditoAnnuo:N}");
                    Console.WriteLine($"IMPOSTA DA VERSARE: € {imposta:N}");
                    Console.WriteLine("==============================");
                    Console.WriteLine();
                }
                else if (scelta == "2")
                {
                    if (contribuenti.Count == 0)
                    {
                        Console.WriteLine("Nessun contribuente è stato analizzato.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Lista completa dei contribuenti:");
                        Console.WriteLine();
                        foreach (Contribuente contribuente in contribuenti)
                        {
                            double imposta = calcoloAliquotaImposta(contribuente.redditoAnnuo);

                            Console.WriteLine("==============================");
                            Console.WriteLine($"Contribuente: {contribuente.Nome} {contribuente.Cognome},");
                            Console.WriteLine($"Nato/a il {contribuente.dataDiNascita:dd/MM/yyyy} ({contribuente.sesso}),");
                            Console.WriteLine($"Residente in {contribuente.comune},");
                            Console.WriteLine($"C.F.: {contribuente.codiceFiscale}");
                            Console.WriteLine($"Reddito dichiarato: € {contribuente.redditoAnnuo:N}");
                            Console.WriteLine($"IMPOSTA DA VERSARE: € {imposta:N}");
                            Console.WriteLine("==============================");
                            Console.WriteLine();
                        }
                    }
                }
                else if (scelta == "3")
                {
                    Console.WriteLine("Arrivederci a presto.");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Scelta non valida. Riprova.");
                    Console.WriteLine();
                }
            }
        }

    }
}
