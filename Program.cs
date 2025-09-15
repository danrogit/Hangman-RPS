using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projekt_SpilUge38
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool running = true;
            while (running)
            {
                // Her vises Hovedmenuen som giver 4 forskellige muligheder
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green; // Sæt tekstfarven til grøn
                Console.WriteLine("\r\n███╗░░░███╗░█████╗░██╗███╗░░██╗  ███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗\r\n████╗░████║██╔══██╗██║████╗░██║  ████╗░████║██╔════╝████╗░██║██║░░░██║\r\n██╔████╔██║███████║██║██╔██╗██║  ██╔████╔██║█████╗░░██╔██╗██║██║░░░██║\r\n██║╚██╔╝██║██╔══██║██║██║╚████║  ██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║\r\n██║░╚═╝░██║██║░░██║██║██║░╚███║  ██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝\r\n╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝╚═╝░░╚══╝  ╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("CHOOSE A GAME\n");
                Console.WriteLine("1. Rock, Paper, Scissor");
                Console.WriteLine("2. Hangman");
                Console.WriteLine("3. Credits");
                Console.WriteLine("4. Quit");

                string valg = Console.ReadLine(); // Her ventes der på hvad spilleren tager af valg

                switch (valg) // Vælger mellem flere kodeblokker, baseret på værdien.
                {
                    case "1":
                        RPS();
                        break;
                    case "2":
                        Hangman();
                        Console.ReadKey();
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Credits");
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Quit");
                        break;
                }
            }
        }

        static void RPS() // Sten saks papir
        {
            
            Console.Clear();
            Console.WriteLine("RPS");
            Console.WriteLine("RPS spil");
            Console.ReadKey();
        }

        static void Hangman() // Hangman spiller
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n█░█ ▄▀█ █▄░█ █▀▀ █▀▄▀█ ▄▀█ █▄░█\r\n█▀█ █▀█ █░▀█ █▄█ █░▀░█ █▀█ █░▀█\n\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Start game");
            Console.WriteLine("2. Game rules");
            Console.WriteLine("3. Back to main menu");

            string drValg = Console.ReadKey().KeyChar.ToString(); // Spillerens valg

            switch (drValg)
            {
                case "1":
                    Console.WriteLine("\nStart game");
                    break;
                case "2":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\n█▀▀ ▄▀█ █▀▄▀█ █▀▀   █▀█ █░█ █░░ █▀▀ █▀\r\n█▄█ █▀█ █░▀░█ ██▄   █▀▄ █▄█ █▄▄ ██▄ ▄█\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Et hemmeligt ord bliver valgt automatisk.\n");
                        Console.WriteLine("Du kan se, hvor mange bogstaver ordet har – hvert bogstav vises som en streg '_'.\n");
                        Console.WriteLine("Gæt ét bogstav ad gangen.\n - Rigtigt bogstav > det bliver vist på sin plads i ordet.\n - Forkert bogstav → du mister et liv.\n");
                        Console.WriteLine("Du starter med 5 liv. Når du mister alle liv, har du tabt.\n");
                        Console.WriteLine("Hvis du gætter hele ordet, vinder du spillet.\n");
                        Console.WriteLine("Når spillet er slut, kan du vælge at prøve igen eller gå tilbage til menuen.\n");
                    break;
                case "3":
                    Console.WriteLine("\nBack to main menu");
                    break;
            }

            Console.WriteLine("< PRESS ANY KEY TO GO BACK");

            Console.ReadKey();
        }
    }
}


