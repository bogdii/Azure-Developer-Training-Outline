using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02StringOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sentence = "The quick brown fox jumps over the lazy dog";

            int stringLenght = sentence.Length;

            Console.WriteLine(stringLenght);

            string s1 = sentence.Substring(4); // quick brown fox jumps over the lazy dog

            Console.WriteLine(s1);

            string s2 = sentence.Substring(4, 5);

            Console.WriteLine(s2); // quick

            bool containsWord = sentence.Contains("jumps");

            Console.WriteLine(containsWord);

            bool b1 = true;
            bool b2 = false;

            string lowerCase = sentence.ToLower();
            string upperCase = sentence.ToUpper();

            string s3 = "the" + "quick" + "brown";

            string s4 = sentence + "again";

            string s5 = "quick".ToUpper();

            string s6 = sentence.Replace("jumps", "leaps");

            int position = sentence.IndexOf("quick");

            Console.ReadKey();

        }
    }
}
