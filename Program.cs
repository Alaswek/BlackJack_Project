using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Leaf.xNet;
namespace Help
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BlackJack Project";

            var Jucator = new Jucator("Casian");
            var Dealer = new Dealer();
            var pachet = new Pachet();

            bool aPierdut = false;

            Jucator.Trage_Carte(pachet.TrageCarteDinPachet());
            Jucator.Trage_Carte(pachet.TrageCarteDinPachet());


            int total_jucator = Jucator.Calculeaza_Punctaj();
            while (total_jucator <= 21 && aPierdut == false)
            {
                Console.WriteLine($"[{Jucator.Nume}] Punctajul tau este {total_jucator}. Doresti sa tragi carte (da/nu)?");
                string rsp = Console.ReadLine();
                if (rsp == "da")
                {
                    Jucator.Trage_Carte(pachet.TrageCarteDinPachet());
                    total_jucator = Jucator.Calculeaza_Punctaj();
                    if (total_jucator > 21)
                    {
                        Console.WriteLine($"[{Jucator.Nume}] Ai pierdut! Punctaj: {total_jucator}");
                        aPierdut = true;
                    }
                    else
                    {
                        Console.WriteLine($"[{Jucator.Nume}] Punctajul tău acum este de: {total_jucator}");
                    }
                }
                else if (rsp == "nu")
                {
                    Console.WriteLine($"[{Jucator.Nume}] Te-ai oprit cu un punctaj de: {total_jucator}");
                    break;
                }
                else
                {
                    Console.WriteLine("[{Jucator.Nume}] Răspuns invalid. Te rog să răspunzi cu 'da' sau 'nu'.");
                }
            }

            Console.WriteLine("\n\n\n");


            Dealer.Trage_Carte(pachet.TrageCarteDinPachet());
            Dealer.Trage_Carte(pachet.TrageCarteDinPachet());
            int total_dealer = Dealer.Calculeaza_Punctaj();
            bool aTerminat_Dealerul = false;
            Console.WriteLine($"[{Dealer.Nume}] Punctajul acum este de: {total_dealer}");
            while (total_dealer <= 21 && !aTerminat_Dealerul)
            {
                Dealer.Trage_Carte(pachet.TrageCarteDinPachet());
                total_dealer = Dealer.Calculeaza_Punctaj();
                Console.WriteLine($"[{Dealer.Nume}] Punctajul acum este de: {total_dealer}");
                if (total_dealer > 21)
                {
                    Console.WriteLine($"[{Dealer.Nume}] A pierdut! Punctaj: {total_dealer}");
                    aTerminat_Dealerul = true;
                }
            }

            Console.WriteLine("\n\n");

            if ( total_dealer <= 21 && total_jucator > 21 && aPierdut == true)
            {
                Console.WriteLine("=========================");
                Console.WriteLine($"#{Dealer.Nume} a câștigat");
                Console.WriteLine("=========================");
            }
            else if ( total_jucator <= 21 && total_dealer > 21 && aTerminat_Dealerul == true)
            {
                Console.WriteLine("=========================");
                Console.WriteLine($"#{Jucator.Nume} a câștigat");
                Console.WriteLine("=========================");
            }
            else
            {
                Console.WriteLine("=========================");
                Console.WriteLine("# Nimeni nu a castigat");
                Console.WriteLine("=========================");
            }


            Console.ReadKey();
        }


    }
}
