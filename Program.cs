using System;
using System.Collections.Generic;
using System.Linq;
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
                // Her vises "Hovedmenuen som giver 3 forskellige muligheder
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green; // Sæt tekstfarven til grøn
                Console.WriteLine("=== Hovedmenu ===");
                Console.WriteLine("1. Start game");
                Console.WriteLine("2. Rules");
                Console.WriteLine("3. Quit game");

                string valg = Console.ReadLine(); // Her ventes der på hvad spilleren tager af valg

                switch (valg) // Vælger mellem flere kodeblokker, baseret på værdien.
                {
                    case "1":
                        StartGame();
                        break;
                    case "2":
                        Console.WriteLine("Regler: Sten slår saks, saks slår papir, papir slår sten");
                        Console.ReadKey();
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Quit game");
                        break;



                }
            }
}
