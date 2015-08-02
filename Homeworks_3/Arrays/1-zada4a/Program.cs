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
            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                {
                    if (arr[i] % 2 == 0)
                    {
                        result = result += arr[i];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}
