using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zada4a
{
    class Automobile : Car
    {
        private int fuel;

        public int Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }
        public Automobile(int fuel, int price, string model)
            : base(price)
        {
            this.fuel = Fuel;
            Console.WriteLine("Fuel: {0} liters/100km / Price: {1} / Model: {2}", fuel, Price, model);
        }
    }
}
