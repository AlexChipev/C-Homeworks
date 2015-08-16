using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zada4a_Var2
{
    class Automobile : Car
    {
        private int fuel;

        public int Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }
        public Automobile(int price, int fuel)
            : base(price)
        {
            this.fuel = Fuel;
            Console.WriteLine("Price: {0} / Fuel: {1} liters/100km", price, fuel);
        }
    }
}
