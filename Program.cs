using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projekt_SpilUge38
{
    /// <summary>
    ///  A small console game made with C#, that includes Rock, Paper & Scissor + Hangman. 
    /// </summary>
    /// 
    internal class Program
    {
        static void Main(string[] args)
        {

            bool running = true;
            while (running)
            {
                // Her vises Hovedmenuen som giver 4 forskellige muligheder. Hovedmenuen er oprettet af Daniel og Casper. 
                // Hovedmenuen udgøre 2 forskellige spil, og inde i hvert spil, findes reglerne. 
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
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Credits\n\n");

                        Console.WriteLine("The most awesome game ever created by Casper & Daniel");

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
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n█▀█ █▀█ █▀▀ █▄▀   █▀█ ▄▀█ █▀█ █▀▀ █▀█   █▀ █▀▀ █ █▀ █▀ █▀█ █▀█\n█▀▄ █▄█ █▄▄ █░█   █▀▀ █▀█ █▀▀ ██▄ █▀▄   ▄█ █▄▄ █ ▄█ ▄█ █▄█ █▀▄\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Start game");
                Console.WriteLine("2. Rules");
                Console.WriteLine("3. Back to main menu");
                Console.WriteLine("\nType ´1´ to play, ´2´ for rules, '3' to go back to the main menu.");
                

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
                    case "3":
                        inMenu = false;
                        break;
                }
            }
        }

        static void Rules() // Her starter vores kodeblok om regler. 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n█▀█ █▀█ █▀▀ █▄▀   █▀█ ▄▀█ █▀█ █▀▀ █▀█   █▀ █▀▀ █ █▀ █▀ █▀█ █▀█\n█▀▄ █▄█ █▄▄ █░█   █▀▀ █▀█ █▀▀ ██▄ █▀▄   ▄█ █▄▄ █ ▄█ ▄█ █▄█ █▀▄\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Rock beats scissor");
            Console.WriteLine("Scissor beats paper");
            Console.WriteLine("Paper beats rock");
            Console.WriteLine("\nTry to beat the computer. You have a 33.3% chance of winning each game \nif both you and the computer choose completly at random");
            Console.WriteLine("\n\n=== Good Luck, and have fun! :D ===");
            
        }

        static void PlayGame() // Her starter vores kodeblok. 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n█▀█ █▀█ █▀▀ █▄▀   █▀█ ▄▀█ █▀█ █▀▀ █▀█   █▀ █▀▀ █ █▀ █▀ █▀█ █▀█\n█▀▄ █▄█ █▄▄ █░█   █▀▀ █▀█ █▀▀ ██▄ █▀▄   ▄█ █▄▄ █ ▄█ ▄█ █▄█ █▀▄\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Choose Rock, Paper, or Scissor");
            Console.Write("Your turn\n");
            string brugerValg = Console.ReadLine().ToLower(); // ToLower gør at hvis jeg glemmer det skal skrives med småt, og det bliver stor skrift, vil computeren
            // ændre det til småt. 

            // Computerens valg
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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win!"); 
            }
            else if (brugerValg == "rock" || brugerValg == "scissor" || brugerValg == "paper")
                {
                Console.ForegroundColor = ConsoleColor.Red;
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
            string[] hangmanWords =
             { "programming","algorithm","variable","function","loop","array","database",
            "server","client","network","object","class","interface","compiling","debugging","terminal",
            "repository","versioning","backend","frontend" };

            bool hangmanRun = true;

            while (hangmanRun)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\r\n█░█ ▄▀█ █▄░█ █▀▀ █▀▄▀█ ▄▀█ █▄░█\r\n█▀█ █▀█ █░▀█ █▄█ █░▀░█ █▀█ █░▀█\n\n");

                // Gør tekst hvid
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Start game");
                Console.WriteLine("2. Game rules");
                Console.WriteLine("3. Back to main menu");

                Console.WriteLine("\nType ´1´ to play, ´2´ for rules, '3' to go back to the main menu.");

                string drChoice = Console.ReadKey().KeyChar.ToString(); // Spillerens valg

                switch (drChoice)
                {
                    case "1":
                        drGame(hangmanWords);
                        break;
                    case "2":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\r\n█▀▀ ▄▀█ █▀▄▀█ █▀▀   █▀█ █░█ █░░ █▀▀ █▀\r\n█▄█ █▀█ █░▀░█ ██▄   █▀▄ █▄█ █▄▄ ██▄ ▄█\n\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("A secret word is chosen automatically.\n");
                        Console.WriteLine("You can see how many letters the word has – each letter is shown as a dash '_'.\n");
                        Console.WriteLine("Guess one letter at a time.\n - Correct letter > it will be shown in its place in the word.\n - Wrong letter → you lose a life.\n");
                        Console.WriteLine("You start with 5 lives. When you lose all your lives, you have lost.\n");
                        Console.WriteLine("If you guess the whole word, you win the game.\n");
                        Console.WriteLine("When the game is over, you can choose to try again or go back to the menu.\n");
                        Console.WriteLine("\nPRESS ANY KEY TO GO BACK");
                        Console.ReadKey();
                        break;
                    case "3":
                        hangmanRun = false;
                        break;
                }
            }
        }
        // ASCII hangman fra https://inventwithpython.com/bigbookpython/project34.html
        static string drHangmanArt(int drLives)
        {
            switch (drLives) 
            {
                case 5:
                    return @"
 +--+
 |  |
    |
    |
    |
    |
=====";
                case 4:
                    return @"
 +--+
 |  |
 O  |
    |
    |
    |
=====";
                case 3:
                    return @"
 +--+
 |  |
 O  |
 |  |
    |
    |
=====";
                case 2:
                    return @"
 +--+
 |  |
 O  |
/|  |
    |
    |
=====";
                case 1:
                    return @"
 +--+
 |  |
 O  |
/|\ |
    |
    |
=====";
                case 0:
                    return @"
 +--+
 |  |
 O  |
/|\ |
/   |
    |
=====";
                default:
                    return @"
 +--+
 |  |
 O  |
/|\ |
/ \ |
    |
=====";
            }
        }

        // Alfabet så det er nemmere for brugeren at se deres valg
        static string drAlphabet(List<char> drGuessedLetters)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // Laver en linje til alfabetet
            StringBuilder drLine = new StringBuilder();

            for (int i = 0; i < alphabet.Length; i++)
            {
                char letter = alphabet[i];
                if (drGuessedLetters.Contains(letter))
                    drLine.Append("_ ");
                else
                    drLine.Append(letter + " ");
            }

            return $"Letters not used:\n{drLine.ToString().Trim()}";

        }

        // Hangman spillet
        static void drGame(string[] hangmanWords)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            // Vælg et tilfældigt ord
            Random drRandom = new Random();
            string drRandomWord = hangmanWords[drRandom.Next(hangmanWords.Length)].ToUpper();
            
            // Definerer spil variablerne
            char[] drGuessedWord = new char[drRandomWord.Length];
            List<char> drGuessedLetters = new List<char>();
            int drLives = 5;
            bool drGameWon = false;

            // Indsætter '_'
            for (int i = 0; i < drRandomWord.Length; i++)
            {
                drGuessedWord[i] = '_';
            }

            // While løkke til spillet
            while (drLives > 0 && !drGameWon)
            {
                Console.Clear();
             

                // hangmanArt ASCII art
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(drHangmanArt(drLives));
                Console.ForegroundColor = ConsoleColor.White;

                // Vis nuværende stadie
                Console.WriteLine("\nWord: " + string.Join(" ", drGuessedWord));
                
                // Vis alfabetet
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n" + drAlphabet(drGuessedLetters));
                Console.ForegroundColor = ConsoleColor.White;

                // Vis gættede bogstaver
                if (drGuessedLetters.Count > 0)
                {
                    Console.WriteLine("\nYour guessed letters: " + string.Join(", ", drGuessedLetters));
                }

                Console.WriteLine("\nEnter a letter: ");
                

                string input = Console.ReadLine().ToUpper(); // ToUpper så alt er blokbogstaver
                
                if (string.IsNullOrEmpty(input) || input.Length != 1 || !char.IsLetter(input[0]))
                {
                    Console.WriteLine("Please enter one letter.");
                    Console.ReadKey();
                    continue;
                }

                char guess = input[0];

                // Tjek om spilleren allerede har gættet det bogstav
                if (drGuessedLetters.Contains(guess))
                {
                    Console.WriteLine("You already guessed that letter!");
                    Console.ReadKey();
                    continue;
                }

                // Tiilføj bogstav til gættede bogstaver
                drGuessedLetters.Add(guess);

                // Tjek om bogstavet er i spillets valgte ord
                bool drCorrectGuess = false;
                for (int i = 0; i < drRandomWord.Length; i++)
                {
                    if (drRandomWord[i] == guess)
                    {
                        drGuessedWord[i] = guess;
                        drCorrectGuess = true;
                    }
                }

                // Rigtig/forkert gæt
                if (drCorrectGuess) // Rigtigt gæt
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else // Forkert gæt
                {
                    drLives--;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong!");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                // Check if word is complete
                drGameWon = !drGuessedWord.Contains('_');

                if (!drGameWon && drLives > 0) // Hvis spillet er vundet og liv er højere end 0
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }

            // Spil afsluttet og resultat vises
            Console.Clear();
            
            // Endelig resultat
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(drHangmanArt(drLives));
            Console.ForegroundColor = ConsoleColor.White;

            if (drGameWon) // Spiller vandt
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nYou won! \nThe word was '{drRandomWord}'");
            }
            else // Spiller tabte
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nYou lost! \nThe word was '{drRandomWord}'");
            }

            // Spil slut, gå til menu og spil igen, eller gå ud

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPress any key to go back to the Hangman menu");
            Console.ReadKey();


        }

    }
}



