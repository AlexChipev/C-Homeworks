using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Type in a short text:");
                string text = Console.ReadLine();
                string[] array = text.Split(' ');
                Array.Sort(array);
                Console.WriteLine();

                Console.WriteLine("Sorted words below:");
                Console.WriteLine();
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
        }
    }
}