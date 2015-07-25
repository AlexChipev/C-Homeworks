using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your points: ");
            short points = short.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("You have: ");

            switch (points)
            {
                case 1:
                case 2: 
                case 3:
                    Console.WriteLine();
                    Console.WriteLine(points +5);
                    break;

                case 4:
                case 5:
                case 6:
                    Console.WriteLine();
                    Console.WriteLine(points * 12);
                    break;

                case 7:
                case 8:
                case 9:
                    Console.WriteLine();
                    Console.WriteLine(points * 50 / 3);
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("No such points!");
                    break;
            }
            Console.WriteLine();
        }
    }
}
