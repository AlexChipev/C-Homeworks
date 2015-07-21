using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDevide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a real number: ");
            float real = float.Parse(Console.ReadLine());

            Console.Write("Enter a hole number: ");
            int whole = int.Parse(Console.ReadLine());

            double result = real / whole;

            Console.WriteLine();
            Console.WriteLine("Devide result: {0}", result);
            Console.WriteLine();
        }
    }
}
