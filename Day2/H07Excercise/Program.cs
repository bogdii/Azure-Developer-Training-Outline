using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H07Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> morseCodeDict = new Dictionary<string, string>()
        {
            { "a", ".-" }, { "b", "-..." }, { "c", "-.-." },
            { "d", "-.." }, { "e", "." }, { "f", "..-." },
            { "g", "--." }, { "h", "...." }, { "i", ".." },
            { "j", ".---" }, { "k", "-.-" }, { "l", ".-.." },
            { "m", "--" }, { "n", "-." }, { "o", "---" },
            { "p", ".--." }, { "q", "--.-" }, { "r", ".-." },
            { "s", "..." }, { "t", "-" }, { "u", "..-" },
            { "v", "...-" }, { "w", ".--" }, { "x", "-..-" },
            { "y", "-.--" }, { "z", "--.." },
            { "1", ".----" }, { "2", "..---" }, { "3", "...--" },
            { "4", "....-" }, { "5", "....." }, { "6", "-...." },
            { "7", "--..." }, { "8", "---.." }, { "9", "----." },
            { "0", "-----" }
        };

            Console.Write("Enter a message to translate to Morse code: ");
            string inputMessage = Console.ReadLine().ToLower();

            Console.WriteLine("Morse code:");
            foreach (char c in inputMessage)
            {
                if (morseCodeDict.ContainsKey(c.ToString()))
                {
                    Console.Write(morseCodeDict[c.ToString()] + " ");
                }
                else if (c == ' ')
                {
                    Console.Write("/ ");
                }
            }

            Console.WriteLine("\n");

            Console.Write("Enter a Morse code message to translate to text: ");
            string inputMorseCode = Console.ReadLine();

            Console.WriteLine("Text:");
            foreach (string code in inputMorseCode.Split(' '))
            {
                foreach (KeyValuePair<string, string> pair in morseCodeDict)
                {
                    if (pair.Value == code)
                    {
                        Console.Write(pair.Key);
                    }
                }

                if (code == "/")
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
