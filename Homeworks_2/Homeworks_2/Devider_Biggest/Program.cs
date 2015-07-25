using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devider_Biggest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 positive numbers:");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int max = int.MinValue;
            
            for (int i = 1; i <= first; i++)
            {
                for (int j = 1; j <= second; j++)
                {
                    if (first % i == 0 && second % j == 0)
                    {
                        if (i == j && i > max)
                        {
                            max = i;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Larger number which devides both is: {0}", max);
            Console.WriteLine();
        }
    }
}