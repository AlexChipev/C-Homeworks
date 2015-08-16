using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zada4a_Var2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter car`s details:");
            Car[] cars = new Car[10];
            int price, fuel;

            for (int i = 1; i < 6; i++)
            {
                Console.Write("Price: ");
                price = int.Parse(Console.ReadLine());
                Console.Write("Fuel: ");
                fuel = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Automobile {0} has the following details:", i);
                cars[i] = new Automobile(price, fuel);
            }
            Console.WriteLine();
            Console.WriteLine("Enter SUV details: ");

            for (int i = 1; i < 6; i++)
            {
                Console.Write("Price: ");
                price = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose highLander");
                Console.Write("1. Yes \n2. No \nChoose: ");
                int offRoad = int.Parse(Console.ReadLine());
                Console.WriteLine();
                
                if (offRoad == 1)
                {
                    Console.WriteLine("SUV {0} has the following details:", i);
                    cars[i] = new SUV(true, price); 
                }
                else
                {
                    Console.WriteLine("SUV {0} has the following details:", i);
                    cars[i] = new SUV(false, price); 
                }
                Console.WriteLine();
            }
        }
    }
}
