using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("0. Int \n1. Double \n2. String \nChoose: ");
            int choice = int.Parse(Console.ReadLine());
            double number;
            string str;

            Console.WriteLine();
            switch (choice)
            {
                case 0:
                    Console.Write("Enter a whole number: ");
                    number = int.Parse(Console.ReadLine());
                    number++;
                  Console.WriteLine(number);
                  break;

                case 1:
                  Console.Write("Enter a real number: ");
                  number = double.Parse(Console.ReadLine());
                  number++;
                  Console.WriteLine(number);
                  break;

                case 2:
                  Console.Write("Enter a string: ");
                  str = Console.ReadLine();
                  str += " *";
                  Console.WriteLine(str);
                  break;

                default:
                  Console.WriteLine("No such choice!");
                  break;
            }
            Console.WriteLine();
        }
    }
}
