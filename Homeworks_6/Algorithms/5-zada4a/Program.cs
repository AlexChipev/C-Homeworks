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
            Console.WriteLine("Enter a value of the array: ");
            int[] arr = new int[int.Parse(Console.ReadLine())];

            Console.WriteLine("Enter {0} numbers: ", arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

