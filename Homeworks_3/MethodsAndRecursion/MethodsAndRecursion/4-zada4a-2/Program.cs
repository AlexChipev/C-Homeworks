using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_zada4a_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in 4 numbers:");
            Console.WriteLine();
            Console.WriteLine("{0}", EvenOrOdd());
        }

        private static string EvenOrOdd()
        {
            for (int i = 0; i < 4; i++)
            {
                int number = int.Parse(Console.ReadLine());
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("The number is even!");
                    }
                    else if (number % 2 == 1)
                    {
                        Console.WriteLine("The number is odd!");
                    }
                }
                Console.WriteLine();
            }
            string text = "Thank you!";
            return text;
        }
    }
}