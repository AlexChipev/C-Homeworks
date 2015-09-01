using System;
using System.Collections;
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
            Console.WriteLine("Start typing numbers. Fill empty string to stop!");
            Console.WriteLine();
            List<int> list = new List<int>();
            int digit = 0;
            string numbers;

            do
            {
                numbers = Console.ReadLine();
                if (numbers != string.Empty)
                {
                    if (int.TryParse(numbers, out digit))
                    {
                        if (digit > -1 && digit < 1001)
                        {
                            list.Add(digit);
                        }
                    }
                }

            } while (numbers != string.Empty);
            list.Sort();
            int num = 0;
            int counter = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[num] == list[i])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine("Number {0} was typed {1} time(s)", list[num], counter);
                    num = i;
                    counter = 1;
                }
            }
            Console.WriteLine("Number {0} was typed {1} time(s)", list[num], counter);
        }
    }
}