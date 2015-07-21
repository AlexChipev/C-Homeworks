using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st string: ");
            string first = Console.ReadLine();

            Console.Write("Enter 2nd string: ");
            string second = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(second.Length <= first.Length);
            Console.WriteLine();
        }
    }
}
