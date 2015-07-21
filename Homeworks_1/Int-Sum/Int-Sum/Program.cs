using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in 2 integers: ");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Integers sum is: {0}", first + second);
            Console.WriteLine();
        }
    }
}
