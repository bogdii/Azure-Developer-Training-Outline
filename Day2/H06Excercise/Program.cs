using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H06Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "apple", "banana", "cherry", "orange", "strawberry" };
            string word = words[new Random().Next(words.Count)];
            int guessesLeft = 6;
            List<char> guessedLetters = new List<char>();

            Console.WriteLine("Welcome to Hangman!");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(DisplayWord(word, guessedLetters));

                Console.Write("Guess a letter: ");
                char guess = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (!char.IsLetter(guess))
                {
                    Console.WriteLine("Invalid input. Please enter a letter.");
                    continue;
                }

                guess = char.ToLower(guess);

                if (guessedLetters.Contains(guess))
                {
                    Console.WriteLine("You already guessed that letter. Please guess a different letter.");
                    continue;
                }

                guessedLetters.Add(guess);

                if (word.Contains(guess))
                {
                    Console.WriteLine($"Good guess! The letter '{guess}' is in the word.");
                }
                else
                {
                    Console.WriteLine($"Sorry, the letter '{guess}' is not in the word.");
                    guessesLeft--;
                }

                if (guessesLeft == 0)
                {
                    Console.WriteLine($"You ran out of guesses. The word was '{word}'.");
                    break;
                }

                if (HasWon(word, guessedLetters))
                {
                    Console.WriteLine($"Congratulations, you won! The word was '{word}'.");
                    break;
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static string DisplayWord(string word, List<char> guessedLetters)
        {
            string displayedWord = "";

            foreach (char letter in word)
            {
                if (guessedLetters.Contains(letter))
                {
                    displayedWord += letter + " ";
                }
                else
                {
                    displayedWord += "_ ";
                }
            }

            return displayedWord;
        }

        static bool HasWon(string word, List<char> guessedLetters)
        {
            foreach (char letter in word)
            {
                if (!guessedLetters.Contains(letter))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
