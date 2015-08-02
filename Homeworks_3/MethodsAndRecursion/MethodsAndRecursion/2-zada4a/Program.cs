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
            string name;
            name = yourName();
            Console.WriteLine();
            Console.WriteLine("Greetings {0}!", name);
            Console.WriteLine();
        }

        private static string yourName()
        {
            
            Console.Write("Enter your name: ");
            string name = string.Concat(Console.ReadLine());
            return name;
        }      
    }
}
