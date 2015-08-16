using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Celsius value: ");
            Fahrenheit fahr = new Fahrenheit();
            fahr.Celsius();
            Console.WriteLine();
        }
    }
}
