using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4a_OOP
{
     class SchoolTeacher : Teacher
    {
        
        private List<string> list = new List<string>();
        
        public List<string> List
        {
            get { return list; }
            set { list = value; }
        }
         public SchoolTeacher()
        {
        } 
        public void ListClasses()
        {
            Random classes = new Random();
            list.Add("5а");
            list.Add("5б");
            list.Add("3в");
            list.Add("3г");
            list.Add("4а");
            list.RemoveAt(classes.Next(0,4));

            Console.Write("This week teaching to classes: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " / ");
            }
            Console.WriteLine();
            ObjectCount++;
        }
        public SchoolTeacher(string name, string lastName, int workExperience, string subject)
            : base(name, lastName, workExperience, subject)
        {
        }
        public void Fun()
        {
            Console.WriteLine("Entertain kids");
        }

    }
}
