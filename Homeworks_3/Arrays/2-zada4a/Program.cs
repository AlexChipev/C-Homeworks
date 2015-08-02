using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array`s value: ");
            int N = int.Parse(Console.ReadLine());
            BigInteger[] arr = new BigInteger[N];
            arr[0] = 0;
            arr[1] = 1;

            Console.WriteLine();
            Console.WriteLine("{0}\n{1}", arr[0], arr[1]);

            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
               
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
        }
    }
}
