using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
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
                Console.WriteLine("888b     d888        d8888 8888888 888b    888      888b     d888 8888888888 888b    888 888     888 \n8888b   d8888       d88888   888   8888b   888      8888b   d8888 888        8888b   888 888     888 \n88888b.d88888      d88P888   888   88888b  888      88888b.d88888 888        88888b  888 888     888 \n888Y88888P888     d88P 888   888   888Y88b 888      888Y88888P888 8888888    888Y88b 888 888     888 \n888 Y888P 888    d88P  888   888   888 Y88b888      888 Y888P 888 888        888 Y88b888 888     888 \n888  Y8P  888   d88P   888   888   888  Y88888      888  Y8P  888 888        888  Y88888 888     888 \n888   \"   888  d8888888888   888   888   Y8888      888   \"   888 888        888   Y8888 Y88b. .d88P \n888       888 d88P     888 8888888 888    Y888      888       888 8888888888 888    Y888  \"Y88888P\"  \n                                                                                                     \n                                                                                                     \n                                                                                                     \n");
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
            bool inMenu = true;
            while (inMenu)
            {

                Console.Clear();
                Console.WriteLine("RPS");
                Console.WriteLine("1. RPS spil");
                Console.WriteLine("2. Rules");
                Console.WriteLine("Type ´1´ to play, ´2´ for rules.");
                Console.ReadKey();

                string valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        RPS();
                        break;

                    case "2":
                        Rules();
                        Console.ReadKey();
                        break;

                }

            }



        }

        static void Hangman() // Hangman spiller
        {
            Console.Clear();
            Console.WriteLine("Game started!");
            Console.WriteLine("Hangman spil");
            Console.ReadKey();
        }
    }
}


