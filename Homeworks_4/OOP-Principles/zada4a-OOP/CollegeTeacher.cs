using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4a_OOP
{
     class CollegeTeacher : Teacher
    {
        
        private string collegeName;

        public string CollegeName
        {
            get { return collegeName; }
            set { collegeName = value; }
        }
        public CollegeTeacher()
        {
        }
        public CollegeTeacher(string name, string lastName, int workExperience, string subject, string collegeName)
            : base(name, lastName, workExperience, subject)
        {
            this.collegeName = collegeName;
            Console.WriteLine("{0}", collegeName);
        }
        public void ScienceAtricle()
        {
            Console.WriteLine("Writes science articles");
            ObjectCount++;
        }
    }
}
