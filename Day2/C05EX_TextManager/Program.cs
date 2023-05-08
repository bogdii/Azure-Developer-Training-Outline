using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05EX_TextManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog.";

            TextManager textManager = new TextManager();

            textManager.LoadSentence(sentence);

            string longestWord = textManager.GetLongestWord();
            Console.WriteLine($"The longest word is: {longestWord}");

            string[] longestWords = textManager.GetAllLongestWords();
            Console.WriteLine("All the longest words are:");
            foreach (string word in longestWords)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }
    }
}
