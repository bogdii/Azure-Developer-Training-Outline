using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that initializes a list of 10 numbers and uses a loop to calculate the average of the numbers.
            int index, numbers, sum = 0;

            for (index = 1; index <= 10; index++)
            {
                Console.WriteLine($"Please enter your number {index}:", index);
                numbers = Convert.ToInt32(Console.ReadLine());
                sum += numbers;
            }
            double avr = sum / 10;
            Console.WriteLine("The average of all your 10 numbers is " + avr);
            Console.ReadLine();
        }
    }
}
