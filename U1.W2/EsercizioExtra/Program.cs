using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioExtra
{
    internal class Program
    {
        public static void start()
        {


            while (true)
            {
                Console.WriteLine("==== Agenzia immobiliare ====");
                Console.WriteLine("1) Mostra gli appartamenti disponibili.");
                Console.WriteLine("2) Inserisci appartamento");
                Console.WriteLine("3) Ricerca avanzata");
                Console.WriteLine("4) Esci");
                int scelta = int.Parse(Console.ReadLine());

                if (scelta == 1)
                {
                    mostraAppartamenti();
                }
                else if (scelta == 2)
                {
                    inserisciAppartamento();
                }
                else if (scelta == 3)
                {
                    ricercaAvanzata();
                }
                else if (scelta == 4)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Opzione non valida");
                }
            }

        }
        static List<Appartamenti> appartamenti = new List<Appartamenti>();

        public static void mostraAppartamenti()
        {
            foreach (Appartamenti a in appartamenti)
            {
                Console.WriteLine($"{a.TipoAppartamento} di {a.Vani} vani in {a.Zona} di metri quadrati {a.MetriQ} con {(a.terrazzoGiardino ?"Terrazzo" : "Giardino" )}");
            }
        }
        public static void inserisciAppartamento ()
        {
            Console.WriteLine("Quanti vani?");
            int Vani = int.Parse(Console.ReadLine());
            Console.WriteLine("Terrazza(true) o Giardino(false)?");
            bool TerrazzaGiardino = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Tipo appartamento?");
            string tipoApp = Console.ReadLine();
            Console.WriteLine("Quanti metri quadrati?");
            int metriQuadrati = int.Parse(Console.ReadLine());
            Console.WriteLine("In che zona si trova?");
            string zonaApp = Console.ReadLine();
            appartamenti.Add(new Appartamenti(Vani,TerrazzaGiardino,tipoApp, metriQuadrati, zonaApp));
        }
        public static void ricercaAvanzata()
        {
            Console.WriteLine("Cerca tutti gli appartamenti con:");
            Console.WriteLine("Quanti vani?");
            int Vani = int.Parse(Console.ReadLine());
            Console.WriteLine("Terrazza(true) o Giardino(false)?");
            bool TerrazzaGiardino = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Tipo appartamento?");
            string tipoApp = Console.ReadLine();
            Console.WriteLine("Quanti metri quadrati?");
            int metriQuadrati = int.Parse(Console.ReadLine());
            Console.WriteLine("In che zona si trova?");
            string zonaApp = Console.ReadLine();
            foreach (Appartamenti app in appartamenti)
            {
                if (app.Vani == Vani|| app.terrazzoGiardino == TerrazzaGiardino|| app.TipoAppartamento == tipoApp || app.MetriQ == metriQuadrati || app.Zona == zonaApp)
                {
                    Console.WriteLine(Convert.ToString($"{app.TipoAppartamento} di {app.Vani} vani in {app.Zona} di metri quadrati {app.MetriQ} con {(app.terrazzoGiardino ? "Terrazzo" : "Giardino")}"));
                }
            }

        }
        static void Main(string[] args)
        {
            appartamenti.Add(new Appartamenti(4, true, "villa", 200, "Zona 2"));
            appartamenti.Add(new Appartamenti(3, false, "appartamento", 110, "Zona 3"));
            appartamenti.Add(new Appartamenti(10, true, "villona", 600, "Periferia"));
            appartamenti.Add(new Appartamenti(2, false, "appartamento", 80, "Centro"));
            start();

        }
    }
}
