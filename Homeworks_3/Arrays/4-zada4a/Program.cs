using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array`s value: ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            Console.WriteLine();
            Console.WriteLine("Enter " + N + " numbers:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Choose one of the numbers and hit enter: ");
            int choice = int.Parse(Console.ReadLine());
            int index = Array.IndexOf(array, choice);

            Console.WriteLine();
            Console.WriteLine("Index is: {0}", index);
            Console.WriteLine();
        }
    }
}

