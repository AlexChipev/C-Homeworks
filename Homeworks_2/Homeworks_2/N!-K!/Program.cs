using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N__K_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers(the first must be larger!):");
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            long result = 1;

            for (int i = K + 1; i <= N; i++)
            {

                result = result *= i;
            }
            Console.WriteLine();
            Console.WriteLine("The result is: {0}", result);
            Console.WriteLine();
        }
    }
}

