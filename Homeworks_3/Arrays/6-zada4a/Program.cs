using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array`s value: ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            Console.WriteLine("Enter " + N + " numbers");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int elementCounter = 0;
            int indexElement = 0;
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        elementCounter++;
                    }
                }
                if (elementCounter > counter)
                {
                    counter = elementCounter;
                    indexElement = i;
                }
                elementCounter = 0;
            }
            Console.WriteLine();
            Console.WriteLine("Most common number is: {0}", array[indexElement]);
            Console.WriteLine("It is typed: {0}", counter + " times");
            Console.WriteLine();
        }
    }
}
