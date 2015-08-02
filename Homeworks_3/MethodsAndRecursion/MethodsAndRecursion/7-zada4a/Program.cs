using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_zada4a
{
    class Program
    {
        static int n = int.Parse(Console.ReadLine());

        static int[] arr = new int[n];

        static void Print()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + 1 + " ");

            }
            Console.WriteLine();
        }
        static void PermNum(int k)
        {
            int temp;
            if (k == 0)
            {
                Print();
            }
            else
            {

                for (int i = 0; i < k; i++)
                {

                    temp = arr[i];
                    arr[i] = arr[k - 1];
                    arr[k - 1] = temp;
                    PermNum(k - 1);

                    temp = arr[i];
                    arr[i] = arr[k - 1];
                    arr[k - 1] = temp;
                }
            }
        }
        static void Main()
        {
            for (int i = 1; i < n; i++)
            {

                arr[i] = i;

            }
            Console.WriteLine();
            PermNum(n);
        }
    }
}

