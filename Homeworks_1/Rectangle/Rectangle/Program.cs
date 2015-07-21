using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rectangle`s parameters:");
            short a = short.Parse(Console.ReadLine());
            short b = short.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Rectangle`s surface is: {0}", a * b);
            Console.WriteLine();
        }
    }
}
