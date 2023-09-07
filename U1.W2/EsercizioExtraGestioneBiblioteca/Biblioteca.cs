using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioExtraGestioneBiblioteca
{

    public class Biblioteca
    {

        public string Tipo { get; set; }
        public int CodiceIdentificativo { get; set; }
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Settore { get; set; }
        public bool Stato { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public int NumeroCell { get; set; }

        public Biblioteca() { }
        public Biblioteca(string tipo,int codice, string titolo, int anno,string settore, bool stato ) 
        {
            Tipo = tipo;
            CodiceIdentificativo = codice;
            Titolo = titolo;
            Anno = anno;
            Settore = settore;
            Stato = stato;

        }
        public Biblioteca(string nome, string cognome, string email, int cell, int codice) 
        {
            Nome = nome;
            Cognome = cognome;
            Email = email;
            NumeroCell = cell;
            CodiceIdentificativo= codice;
        }
        public static List<Biblioteca> archivio = new List<Biblioteca>();
        public static List<Biblioteca> registroPrestiti = new List<Biblioteca>();
        public static void registraPrestito()
        {
            Console.Write("Inserisci il tuo nome : ");
            string nomeP = Console.ReadLine();
            Console.Write("Inserici il tuo cognome : ");
            string cognomeP = Console.ReadLine();
            Console.Write("Inserisci la tua email : ");
            string emailP = Console.ReadLine();
            Console.Write("Inserisci il tuo numero di cellulare : ");
            int cellP = int.Parse(Console.ReadLine());
            Console.Write("Inserisci il codice del DVD o Libro che vuoi prendere in prestito : ");
            int codiceP = int.Parse(Console.ReadLine());
            foreach (Biblioteca b in archivio)
            {
                if (b.CodiceIdentificativo == codiceP)
                {
                    if (b.Stato == true )
                    {
                        b.Stato = false;
                        registroPrestiti.Add(new Biblioteca(nomeP, cognomeP, emailP, cellP, codiceP));
                        Console.WriteLine($"Il {b.Tipo} e' stato preso in prestito con successo.");
                        
                    }
                    else
                    {
                        Console.WriteLine($"Il {b.Tipo} non e' disponibile al momento.");
                    }
                }
            }
        }
        public static void consegnaProdotto()
        {
            Console.Write("Inserisci il codice del prodotto che vuoi restituire : ");
            int codiceP = int.Parse(Console.ReadLine());
            foreach(Biblioteca b in archivio)
            {
                if (b.CodiceIdentificativo == codiceP)
                {
                    if (b.Stato == false )
                    {
                        b.Stato = true;
                        Console.WriteLine($"Il {b.Tipo} e' stato restituito con successo.");
                    }else if (b.Stato == true)
                    {
                        Console.WriteLine($"Il {b.Tipo} e' gia presente nella biblioteca.");
                    }
                }
            }
        }
        public static void stampaPrestiti()
        {
            foreach(Biblioteca b in registroPrestiti)
            {
                Console.WriteLine($"L'utente {b.Nome} {b.Cognome} ha preso in prestito il prodotto con codice: {b.CodiceIdentificativo}");
            }
        }
        public static void stampaDisponibili()
        {
            foreach (Biblioteca b in archivio)
            {
                if(b.Stato == true)
                {
                    Console.WriteLine($"Il {b.Tipo} {b.Titolo} e' DISPONIBILE con il codice {b.CodiceIdentificativo}.");
                }
            }
        }
        public static void startMenu ()
        {
            archivio.Add(new Biblioteca("Libro",1,"Il signore degli anelli: La compagnia dell'anello",1955,"Fantasy",true));
            archivio.Add(new Biblioteca("Libro",2,"Il signore degli anelli: Le due torri",1955,"Fantasy",true));
            archivio.Add(new Biblioteca("Libro", 3, "Il signore degli anelli: Il ritorno del re", 1955, "Fantasy", true));
            archivio.Add(new Biblioteca("Libro", 4, "Lo Hobbit", 1937, "Fantasy", true));
            archivio.Add(new Biblioteca("DVD", 5, "Matrix", 1999, "Fantascienza", true));
            archivio.Add(new Biblioteca("DVD", 6, "Matrix: Reloaded", 2003, "Fantascienza", true));
            archivio.Add(new Biblioteca("DVD", 7, "Matrix: Revolution", 2005, "Fantascienza", true));
            while (true)
            {
                Console.WriteLine("====== Benvenuti nella biblioteca della scuola! ======");
                Console.WriteLine("Scelgli che operazione vuoi svolgere.");
                Console.WriteLine("1) Prendere in prestito un DVD o Libro.");
                Console.WriteLine("2) Restituire un DVD o Libro");
                Console.WriteLine("3) Stampa tutti i DVD e Libri in questo momento disponibili.");
                Console.WriteLine("4) Stamapa l'elenco dei prestiti.");
                Console.WriteLine("0) Esci.");
                Console.Write("Digita un numero :");
                int scelta = int.Parse(Console.ReadLine());

                if(scelta ==1)
                {
                    registraPrestito();
                }else if(scelta ==2)
                {
                    consegnaProdotto();
                }else if (scelta ==3)
                {
                    stampaDisponibili();
                }else if (scelta == 4)
                {
                    stampaPrestiti();
                }else if (scelta ==0)
                {
                    Console.WriteLine("Arrivederci!");
                    Environment.Exit(0);
                }else
                {
                    Console.WriteLine("Scelta non valida.");
                }
            }
        }
    }
}
