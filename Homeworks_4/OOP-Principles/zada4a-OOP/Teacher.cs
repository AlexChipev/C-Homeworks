using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4a_OOP
{
      class Teacher : Person
    {
        private string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public Teacher()
        {
        }
        public Teacher(string name, string lastName, int workExperience, string subject)
            : base(name, lastName, workExperience)
        {
            this.subject = subject;
            Console.WriteLine("Fist, Last name: {0}, {1} \nExperience in years: {2} \nSubject: {3}", 
                                                            name, lastName, workExperience, subject);
        }
        public virtual void HomeworksCheck()
        {
            Console.WriteLine("Ability to check homeworks");
        }
         public void GoodDay()
         {
             Console.WriteLine("Good day!");
         }
         public void GoodBye()
         {
             Console.WriteLine("Good bye!");
             ObjectCount++;
         }
    }
}
