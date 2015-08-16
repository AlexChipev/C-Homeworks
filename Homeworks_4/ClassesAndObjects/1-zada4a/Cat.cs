using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_zada4a
{
    class Cat
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Say()
        {
            Console.WriteLine("Name / Age ");
            Console.WriteLine();
            this.name = "Sisi";
            this.age = 12;
            Console.WriteLine("{0} / {1}", name, age);

            this.name = "Tommy";
            this.age = 9;
            Console.WriteLine("{0} / {1}", name, age);

            this.name = "Sara";
            this.age = 4;
            Console.WriteLine("{0} / {1}", name, age);

            this.name = "Ricky";
            this.age = 6;
            Console.WriteLine("{0} / {1}", name, age);

            this.name = "Lili";
            this.age = 14;
            Console.WriteLine("{0} / {1}", name, age);

            this.name = "Emmi";
            this.age = 9;
            Console.WriteLine("{0} / {1}", name, age);

            this.name = "George";
            this.age = 2;
            Console.WriteLine("{0} / {1}", name, age);

            this.name = "Jerry";
            this.age = 5;
            Console.WriteLine("{0} / {1}", name, age);

            this.name = "Monni";
            this.age = 6;
            Console.WriteLine("{0} / {1}", name, age);

            this.name = "Ketti";
            this.age = 17;
            Console.WriteLine("{0} / {1}", name, age);
            Console.WriteLine();
        }
    }
}


