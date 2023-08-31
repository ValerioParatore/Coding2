using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioLogin
{
    

    public static class User
    {
        public static void startMenu()
        {
            Console.WriteLine("===============OPERAZIONI==============");
            Console.WriteLine("Scegli l’operazione da effettuare:");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Logout");
            Console.WriteLine("3. Verifica ora e data di login");
            Console.WriteLine("4. Lista degli accessi");
            Console.WriteLine("5. Esci");
            Console.WriteLine("========================================");
            int scelta = int.Parse(Console.ReadLine());

            if (scelta == 1)
            {
                logIn();
            }else if (scelta == 2)
            {
                logOut();
            }else if(scelta == 3)
            {
                getTime();
            }
        }
        public static bool IsLogin = false;
        public static string Name { get; set; }
        public static string Password { get; set; }
        public static string PasswordConferma { get; set; }
        public static DateTime date { get; set; }
        public static List<string> storico { get; set; }

        public static void logIn()
        {
            if (IsLogin == false)
            {
                Console.WriteLine("Inserisci il tuo nome");
                Name = Console.ReadLine();
                Console.WriteLine("Inserisci la password");
                Password = Console.ReadLine();
                Console.WriteLine("Conferma la password");
                PasswordConferma = Console.ReadLine();
                if (Password == PasswordConferma)
                {
                    Console.WriteLine("Benvenuto " + Name);
                    date = DateTime.Now;
                    IsLogin = true;
                    string utente = Name + Convert.ToString(date);
                    storico.Add(utente);
                  
                    startMenu();
                }
                else
                {
                    Console.WriteLine("Password non coincide");
                    startMenu();
                }
            }
            else
            {
                Console.WriteLine("Sei gia connesso con l'user: " + Name);
                startMenu();
            }
        }
        public static void logOut()
        {
            if (IsLogin== true) 
            {
                IsLogin = false;
                Console.WriteLine("Logout effettuato!");
                startMenu() ;
            }else
            {
                Console.WriteLine("Non hai ancora effettuato il login");
                startMenu();
            }
        }
        public static void getTime()
        {
            if (IsLogin== true)
            {
                Console.WriteLine("Login effettuato il: " + date);
                startMenu();
            }
            else
            {
                Console.WriteLine("Nessun login effettuato fin ora.");
                startMenu();
            }
        }

    }
}
