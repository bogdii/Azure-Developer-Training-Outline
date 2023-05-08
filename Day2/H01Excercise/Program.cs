using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H01Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:data\tekst";
            string[] files = Directory.GetFiles(directoryPath, "*.txt");
            int grandTotal = 0;

            foreach (string file in files)
            {
                string content = File.ReadAllText(file);
                int count = CountWords(content);
                grandTotal += count;

                Console.WriteLine($"File: {file} \nWord Count: {count}\n");
            }

            Console.WriteLine($"Grand Total Word Count: {grandTotal}");
            Console.ReadLine();
        }

        static int CountWords(string content)
        {
            string[] words = content.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
    
}
