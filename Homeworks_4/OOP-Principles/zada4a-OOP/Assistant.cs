using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4a_OOP
{
    class Assistant : Lecturer
    {
        private bool major;

        public bool Major
        {
            get { return major; }
            set { major = value; }
        }
        private string check;

        public string Check
        {
            get { return check; }
            set { check = value; }
        }
        public Assistant()
        { 
        }
        public void CheckExams()
        {
            this.check = "Ability to check exams";
            Console.WriteLine("{0}", check);
            ObjectCount++;
        }
        public Assistant(string name, string lastName, int workExperience, string university, bool major)
            : base(name, lastName, workExperience, university)
        {
            if (major == true)
            {
              Console.WriteLine("Major assistant");
            }
            else
            {
                Console.WriteLine("Junior assistant");
            }
        }
        public override void HomeworksCheck()
        {
            Console.WriteLine("Access to student`s homeworks");
            
        }

    }
}
