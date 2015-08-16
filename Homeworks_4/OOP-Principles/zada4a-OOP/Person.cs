using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4a_OOP
{
     public class Person
    {
        private string name;

        protected string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string lastName;

        protected string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private int workExperience;

        protected int WorkExperience
        {
            get { return workExperience; }
            set { workExperience = value; }
        }
        protected Person()
        { 
        }
        protected Person(string name, string lastName, int workExperience)
         {
             this.name = name;
             this.lastName = lastName;
             this.workExperience = workExperience;
         }
       static int objectCount;

       public static int ObjectCount
       {
           get { return Person.objectCount; }
           set { Person.objectCount = value; }
       }
       public void Counter(int objectCount)
       {
           ObjectCount = 0;
       }
    }
}
