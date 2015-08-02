using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input matrix size: ");
            int n = int.Parse(Console.ReadLine());

            int[,] array = new int[n, n];
            int row = 0;
            int col = -1;
            int num = 1;
            int step = n;
            string direction = "Right";

            Console.WriteLine();
            for (int j = num; j <= n * n; j++)
            {
                if (direction == "Right")
                {
                    for (int i = 0; i < step; i++)
                    {
                        col++;
                        array[row, col] = num;
                        num++;
                    }
                    direction = "Down";
                    step--;
                }

                if (direction == "Down")
                {
                    for (int i = 0; i < step; i++)
                    {
                        row++;
                        array[row, col] = num;
                        num++;
                    }
                    direction = "Left";
                }

                if (direction == "Left")
                {
                    for (int i = 0; i < step; i++)
                    {
                        col--;
                        array[row, col] = num;
                        num++;
                    }
                    direction = "Up";
                    step--;
                }

                if (direction == "Up")
                {
                    for (int i = 0; i < step; i++)
                    {
                        row--;
                        array[row, col] = num;
                        num++;
                    }
                    direction = "Right";
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(string.Format(array[i, j] + " \t"));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
