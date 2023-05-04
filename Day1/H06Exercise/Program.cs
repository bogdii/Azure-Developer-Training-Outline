using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H06Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number n: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c = 0;

            Console.Write($"{a} {b} ");

            while (c < n)
            {
                c = a + b;
                if (c <= n)
                {
                    Console.Write($"{c} ");
                }
                a = b;
                b = c;
            }

            Console.ReadLine();
        }
    }
}
