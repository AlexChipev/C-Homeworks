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
            Console.WriteLine("Cars and SUVs info: ");
            Console.WriteLine();

            Car[] cars = new Car[10];
            
            cars[0] = new SUV(true, 40000, "BmwX5");
            Console.WriteLine();
            cars[1] = new SUV(false, 35000, "BmwX3");
            Console.WriteLine();
            cars[2] = new SUV(false, 50000, "Lexus");
            Console.WriteLine();
            cars[3] = new SUV(true, 100000, "MercedesG55");
            Console.WriteLine();
            cars[4] = new SUV(true, 45000, "ToyotaLandcruiser");
            Console.WriteLine();
            cars[5] = new Automobile(12, 20000, "AudiA6");
            Console.WriteLine();
            cars[6] = new Automobile(14, 28000, "AudiA8");
            Console.WriteLine();
            cars[7] = new Automobile(9, 10000, "MazdaCX3");
            Console.WriteLine();
            cars[8] = new Automobile(10, 25000, "Bmw5");
            Console.WriteLine();
            cars[9] = new Automobile(15, 80000, "MercedesE320");
            Console.WriteLine();
        }
    }
}
