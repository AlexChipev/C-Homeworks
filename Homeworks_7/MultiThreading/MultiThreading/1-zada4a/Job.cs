using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _1_zada4a
{
    class Job
    {
        public void Running()
        {
            Random rand = new Random();
            Thread.Sleep(rand.Next(1000, 10000));
        }
    }
}
