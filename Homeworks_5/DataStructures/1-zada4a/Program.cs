using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers or emty line:");
            List<string> numbers = new List<string>();
            string num = null;
            float sum = 0;

            do
            {
                num = Console.ReadLine();
                if (float.TryParse(num, out sum))
                {
                    numbers.Add(num);
                }
            } while (num != string.Empty);

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += float.Parse(numbers[i]);
            }
            float aritmetic = sum / numbers.Count;

            Console.WriteLine("Сума: {0}", sum);
            Console.WriteLine("Средно аритметично (до първо число след знак): {0}", aritmetic);
            Console.WriteLine();
        }
    }
}


