using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4a_OOP
{
    class Professor : Lecturer
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string exams;

        public string Exams
        {
            get { return exams; }
            set { exams = value; }
        }
        public Professor()
        {
        }
        public Professor(string name, string lastName, int workExperience, string university, string title)
            : base(name, lastName, workExperience, university)
        {
            this.title = title;
            Console.WriteLine("Title: {0}", title);
        }
        public void ExamsHold()
        {
            this.exams = "Ability to hold exams";
            Console.WriteLine("{0}", exams);
            
        }
        public override void HomeworksCheck()
        {
            Console.WriteLine("Access to student`s homeworks");
           
        }

    }
}
