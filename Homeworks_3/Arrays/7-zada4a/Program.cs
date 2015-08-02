using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value of the array: ");

            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];
            int counter = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[j, i] = counter++;
                }
            }
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
