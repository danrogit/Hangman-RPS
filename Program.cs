using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
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
                if (drCorrectGuess)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    drLives--;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong!");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                // Check if word is complete
                drGameWon = !drGuessedWord.Contains('_');

                if (!drGameWon && drLives > 0)
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
            
            if (drGameWon)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nYou won! \nThe word was '{drRandomWord}'");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nYou lost! \nThe word was '{drRandomWord}'");
            }
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPress any key to go back to the Hangman menu");
            Console.ReadKey();
        }
    }
}


