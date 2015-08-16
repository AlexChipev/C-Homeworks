using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_zada4a
{
    class Fahrenheit
    {
        private float degrees;

        public float Degrees
        {
            get { return degrees; }
            set { degrees = value; }
        }

        public void Celsius()
        {
            byte celsius = byte.Parse(Console.ReadLine());

            this.degrees = (celsius * 1.8F) + 32;

            Console.WriteLine();
            Console.WriteLine("Convert to Fahrenheit: {0} F", degrees);
        }
    }
}
