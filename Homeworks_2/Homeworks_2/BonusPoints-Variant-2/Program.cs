using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints_Variant_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your points: ");
            short points = short.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("You have: ");

            if (points >= 1 && points <= 3)
            {
                Console.WriteLine(points +5);
            }
            else if (points >= 4 && points <= 6)
            {
                Console.WriteLine(points * 12);
            }
            else if (points >= 7 && points <= 9)
            {
                Console.WriteLine(points * 50 / 3);
            }
            else
            {
                Console.WriteLine("No such points!");
            }
            Console.WriteLine();
        }
    }
}
