using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
                

                string valg = Console.ReadLine();

                switch (valg) // Det gør så computeren ved hvilke knap der bliver trykket på.
                {
                    case "1":
                        //Her starter du spillet
                        PlayGame();
                        break;
                    case "2":
                        // Regler 
                        Rules();
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void Rules() // Her starter vores kodeblok om regler. 
        {
            Console.Clear();
            Console.WriteLine("=== Rules for Rock, Paper, Scissor ===");
            Console.WriteLine("Rock beats scissor");
            Console.WriteLine("Scissor beats paper");
            Console.WriteLine("Paper beats rock");
            Console.WriteLine("Try to beat the computer. You have a 33.3% chance of winning each game if both you and the computer");
            Console.WriteLine("choose completly at random");
            Console.WriteLine("=== Good Luck, and have fun! :D ===");
            
        }

        static void PlayGame() // Her starter vores kodeblok. 
        {
            Console.Clear();
            Console.WriteLine("=== Game Starts!");
            Console.WriteLine("Choose Rock, Paper, or Scissor");
            Console.Write("Your turn");
            string brugerValg = Console.ReadLine().ToLower(); // ToLower gør at hvis jeg glemmer det skal skrives med småt, og det bliver stor skrift, vil computeren
            // ændre det til småt. 

            // Computer choice 
            string[] muligheder = { "rock", "paper", "scissor" }; // En array med tre muligheder. mulighed [0] [1] [2]
            Random rnd = new Random(3); // Random generator, i forhold til arrayet.
            string computerValg = muligheder[rnd.Next(muligheder.Length)]; // her fortæller den at længden på arrayet er 3. rnd.Next er tilfældigt

            Console.WriteLine("Computer choices:" + computerValg);

            // Denne opsætning under, gør at vi finder en vinder ud fra ens valg. 
            if (brugerValg == computerValg)
            {                                   // Tjekker om brugerens valg er det samme som computerens. 
                Console.WriteLine("Draw"); 
            }
            else if ((brugerValg == "rock" && computerValg == "scissor")
                  || (brugerValg == "scissor" && computerValg == "paper") // Her laves en opsætning hvor spilleren vinder. 
                  || (brugerValg == "paper" && computerValg == "rock")) // || betyder eller. Vi bruger dette, så det gør det lettere at benytte alle tre muligheder.
            {
                Console.WriteLine("You win!"); 
            }
            else if (brugerValg == "rock" || brugerValg == "scissor" || brugerValg == "paper")
                {
                Console.WriteLine("Computer wins!");
            }
            else
            {
                Console.WriteLine("invalid choice."); // Denne linjer gør at hvis brugeren har tastet forkert, vil den ikke blive gennemført
            }

            Console.WriteLine("\nEnter a key to return to menu...");
            Console.ReadKey();

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



