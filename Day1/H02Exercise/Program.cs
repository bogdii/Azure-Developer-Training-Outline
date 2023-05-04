using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that asks the user for two integers and uses a conditional statement to display 
            //the greater number.

            Console.WriteLine("Enter your first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine($"Number {number1} is greater then {number2}");
            }
            else if (number1 == number2) 
            {
                Console.WriteLine($"The numbers are equal");
            }
            else
            {
                Console.WriteLine($"Number {number2} is greater then {number1}");
            }

            Console.ReadLine();
        }
    }
}
