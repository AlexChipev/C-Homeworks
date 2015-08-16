using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();
            Random b = new Random();
            Random c = new Random();

            for (int i = 0; i < 10; i++)
            {
                int first = a.Next(1, 10);
                int second = b.Next(5, 15);
                int third = c.Next(15, 25);
                Console.WriteLine("{0}", RandomParams(first, second, third));
            }
            Console.WriteLine();
        }

        private static int RandomParams(int a, int b, int c)
        {
            int result = a * b * c;
            return (result);
        }
    }
}
