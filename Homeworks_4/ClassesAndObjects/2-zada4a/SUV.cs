using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zada4a
{
    class SUV : Car
    {
        private bool highLander;

        public bool HighLander
        {
            get { return highLander; }
            set { highLander = value; }
        }
        public SUV(bool highLander, int price, string model)
            : base(price)
        {
            if (this.HighLander != highLander)
            {
                Console.Write("Highlander: Yes");
            }
            else
            {
                Console.Write("Highlander: No");
            }
            Console.Write(" / Price: {0} / Model: {1}", Price, model);
            Console.WriteLine();
        }
    }
}
