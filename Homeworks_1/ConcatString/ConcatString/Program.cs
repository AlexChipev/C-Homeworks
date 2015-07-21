using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 words:");
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(first + " | " + second);
            Console.WriteLine();
        }
    }
}
