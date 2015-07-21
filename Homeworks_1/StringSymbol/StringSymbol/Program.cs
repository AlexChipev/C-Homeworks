using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSymbol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();

            Console.Write("Choose a number from 0 to {0}: ", (word.Length - 1));
            byte N = byte.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("The number refers to the ( {0} ) symbol from the string", word[N]);
            Console.WriteLine();
        }
    }
}
