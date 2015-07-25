using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDevide_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Numbers which cannot be devided by 3 and 7: ");

            for (int i = 1; i <= N; i++)
            {
                if (i % (3 * 7) == 0 )
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
