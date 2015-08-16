using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat[] cat = new Cat[10];
            cat[0] = new Cat();

            foreach (Cat item in cat)
            {
                item.Say();
                break;
            }
        }
    }
}
