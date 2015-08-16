using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zada4a_Var2
{
    class SUV : Car
    {
        private bool highLander;

        public bool HighLander
        {
            get { return highLander; }
            set { highLander = value; }
        }
        public SUV(bool highLander, int price)
            : base(price)
        {
            if (highLander == false)
            {
                Console.WriteLine("Not a highlander");
            }
            else
            {
                Console.WriteLine("Highlander");
            }
            Console.Write("Price: {0}", Price);
            Console.WriteLine();
        }
    }
}
