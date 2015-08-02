using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in the first array`s length: ");
            int N = int.Parse(Console.ReadLine());
            int[] arr1 = new int[N];

            Console.Write("Type in the second array`s length: ");
            int M = int.Parse(Console.ReadLine());
            int[] arr2 = new int[M];

            if (N != M)
            {
                Console.WriteLine("The arrays are not equal by length!");
            }
            else
            {
                Console.WriteLine("Type in " + (M + N) + " values:");
                for (int i = 0; i < arr1.Length; i++)
                {
                    arr1[i] = int.Parse(Console.ReadLine());
                    arr2[i] = int.Parse(Console.ReadLine());

                    if (arr1[i] != arr2[i])
                    {
                        Console.WriteLine("Equal by length but not by values");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Equal!");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}