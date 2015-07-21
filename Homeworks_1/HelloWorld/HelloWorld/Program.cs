using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello world!";
            string check = "hello world!";

            int symbols = hello.Length;

            Console.WriteLine(hello.Length == check.Length);
            Console.WriteLine(symbols + " symbols");
            Console.WriteLine();
        }
    }
}
