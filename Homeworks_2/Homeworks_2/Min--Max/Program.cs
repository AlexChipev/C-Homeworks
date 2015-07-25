using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min__Max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers you want to type? ");
            short N = short.Parse(Console.ReadLine());

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < N; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers > max)
                {
                    max = numbers;
                }
                if (numbers < min)
                {
                    min = numbers;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The larger is: {0}", max);
            Console.WriteLine("The smaller is: {0}", min);
            Console.WriteLine();
        }
    }
}
