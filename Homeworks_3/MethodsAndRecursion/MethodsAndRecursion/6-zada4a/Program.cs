using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _6_zada4a
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0}! is: {1}", number, Recursive(number));
            Console.WriteLine();
        }

        static BigInteger Recursive(BigInteger number)
        {
            if (number == 1)
            {
                return 1;
            }
            return number * Recursive(number - 1);
        }
    }
}
