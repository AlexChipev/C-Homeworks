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
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 10;
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
        }
    }
}
