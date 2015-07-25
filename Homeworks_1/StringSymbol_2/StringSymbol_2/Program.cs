using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSymbol_2
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
            Console.WriteLine("If the second string consists symbols from the first you will see it:");
            Console.WriteLine();

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if (second[j] == first[i])
                    {
                        Console.Write(second[j]);
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
