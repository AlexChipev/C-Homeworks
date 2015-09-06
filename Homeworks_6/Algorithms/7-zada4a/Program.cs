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
            Console.Write("Enter the arrays value: ");
            int value = int.Parse(Console.ReadLine());
            int[] array = new int[value];
            Console.WriteLine("Start typing numbers:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine(StackSort(array));
            int stackSort = Environment.TickCount;
            Console.WriteLine("StackSort time in miliseconds: " + (Environment.TickCount - stackSort));
            Console.WriteLine();

            Console.WriteLine(ListSort(array));
            int listSort = Environment.TickCount;
            Console.WriteLine("BubbleSort time in miliseconds: " + (Environment.TickCount - listSort));
            Console.WriteLine();
        }
        public static int StackSort(int[] array)
        {
            Stack<int> stack = new Stack<int>();
            int[] arr = array;
            int result = 0;

            Console.WriteLine("Even numbers:");
            for (int i = 0; i < arr.Length; i++)
            {
                stack.Push(arr[i]);
                if (arr[i] % 2 == 1)
                {
                    stack.Pop();
                }
                else
                {
                    Console.Write(arr[i] + " ");
                }
            }
            return result;
        }
        public static int ListSort(int[] array)
        {
            int[] arr = array;
            int temp = 0;
            LinkedList<int> reverse = new LinkedList<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    reverse.AddFirst(arr[i]);
                }
            }
            Console.WriteLine("Odd numbers: ");
            foreach (var item in reverse)
            {
                Console.Write(item + " ");
            }
            return temp;
        }
    }
}
