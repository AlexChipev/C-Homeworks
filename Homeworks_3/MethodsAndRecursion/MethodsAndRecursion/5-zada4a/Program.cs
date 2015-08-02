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
            for (int i = 10; i <= 999; i++)
            {
                SymetricNumbers(i);
            }
        }

        static void SymetricNumbers(int number)
        {
            if (number < 100 && number % 11 == 0)
            {
                Console.WriteLine(number);
            }
            else if (number >= 100)
            {
                int firstNumber = number / 100;
                int secondNumber = number % 10;

                if (firstNumber == secondNumber)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
