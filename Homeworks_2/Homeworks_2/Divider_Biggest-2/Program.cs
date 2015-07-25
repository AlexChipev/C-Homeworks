using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divider_Biggest_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers:");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 1; i < first + second; i++)
            {
                if (first % i == 0 && second % i == 0)
                {
                    result = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The larger number which devides both is: {0}", result);
            Console.WriteLine();
        }
    }
}
