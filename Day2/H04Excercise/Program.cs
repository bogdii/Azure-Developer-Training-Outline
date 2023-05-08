using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace H04Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word or phrase: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine($"{input} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome.");
            }

            Console.ReadLine();
        }

        static bool IsPalindrome(string input)
        {
            // Remove spaces, punctuation, and convert to lowercase
            string cleanInput = Regex.Replace(input, @"[^a-zA-Z0-9]", "").ToLower();

            // Reverse the string
            char[] chars = cleanInput.ToCharArray();
            Array.Reverse(chars);
            string reversedInput = new string(chars);

            // Check if the string is a palindrome
            return cleanInput == reversedInput;

            
        }
        
    }
    
}
