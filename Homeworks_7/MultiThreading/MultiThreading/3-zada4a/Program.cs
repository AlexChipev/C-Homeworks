using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _3_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasking new1 = new Tasking();
            new1.DoTask1();
            Tasking new2 = new Tasking();
            new2.DoTask2();
            new1.DoTask3();
        }
    }
}
