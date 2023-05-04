using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H01Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that initializes a variable 'n' with a positive integer and prints the
            //sum of all even numbers from 1 to 'n' using a loop.

            Console.WriteLine("Please enter your number:");

            int number = Convert.ToInt32(Console.ReadLine());
            int index, sum = 0;

            for (index = 2; index <= number; index += 2)
            {
                sum += index;
            }
            Console.WriteLine($"sum of all even numbers from 1 to {number} is " + sum);

            Console.ReadLine();
        }
    }
}
