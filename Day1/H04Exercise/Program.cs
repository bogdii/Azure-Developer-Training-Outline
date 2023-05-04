using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace H04Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPrime(int n)
            {
                if (n == 1 || n == 0) // eleminating 0 and 1
                {
                    return false;
                }
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0){
                        return false;
                    }
                }

                return true;
            }

            int N = 100;
            for (int i = 1; i <= N; i++)
            {
                if (isPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
