﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zada4a_Var2
{
    class Car
    {
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public Car(int price)
        {
            this.price = price;
        }
    }
}