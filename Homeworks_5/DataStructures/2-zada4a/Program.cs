using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Console.WriteLine("How many numbers you want to type in?");
            int value = int.Parse(Console.ReadLine());
            int[] result = new int[value];

            Console.WriteLine();
            for (int i = 0; i < value; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                stack.Push(numbers);
                if (numbers % 2 == 1)
                {
                    stack.Pop();
                }
                else
                {
                    result = stack.ToArray();
                }
            }
            Console.WriteLine();
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
