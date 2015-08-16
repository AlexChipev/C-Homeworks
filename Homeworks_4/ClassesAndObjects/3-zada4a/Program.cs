using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dimensions of the triangle`s cathetus:");
            RightTriangle triangle = new RightTriangle();
            triangle.Hypotenuse();
            triangle.Angles();
            Console.WriteLine();
        }
    }
}
