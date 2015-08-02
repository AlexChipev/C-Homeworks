using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers:");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("The larger number is: {0}", MaxNumber(MaxNumber(first, second), third));
            Console.WriteLine();
        }

        private static int MaxNumber(int a, int b)
        {
            if (a > b)
            return a;
            else return b;
        }
    }
}
