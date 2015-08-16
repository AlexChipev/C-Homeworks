using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4a_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose from the list below to see the details");
            Console.Write("1. Teachers \n2. Lecturers \n3. ShcoolTeachers \n4. CollegeTeachers\n5. Professors \n6. Assistants \nChoose: ");
            byte choice = byte.Parse(Console.ReadLine());

            Console.WriteLine();
            switch (choice)
            {
                case 1:
                    Teacher first = new Teacher("Ivan", "Georgiev", 6, "Math");
                    first.HomeworksCheck();
                    first.GoodDay();
                    first.GoodBye();
                    Console.WriteLine();
                    Teacher second = new Teacher("Anton", "Ivanov", 9, "Literature");
                    first.HomeworksCheck();
                    first.GoodDay();
                    first.GoodBye();
                    break;
                case 2:
                    Lecturer lecturer1 = new Lecturer("Georgy", "Tonchev", 7, "University of Sofia");
                    lecturer1.Lectures();
                    lecturer1.HomeworksCheck();
                    lecturer1.GoodDay();
                    Console.WriteLine();
                    Lecturer lecturer2 = new Lecturer("Stoyan", "Iliev", 5, "University of Varna");
                    lecturer2.Lectures();
                    lecturer2.HomeworksCheck();
                    lecturer2.GoodDay();
                    break;
                case 3:
                    SchoolTeacher school1 = new SchoolTeacher("Stoimen", "Peshev", 10, "Biology");
                    school1.ListClasses();
                    school1.HomeworksCheck();
                    school1.Fun();
                    Console.WriteLine();
                    SchoolTeacher school2 = new SchoolTeacher("Iliana", "Arnaudova", 4, "Chemistry");
                    school2.ListClasses();
                    school2.HomeworksCheck();
                    school2.Fun();
                    Console.WriteLine();
                    SchoolTeacher school3 = new SchoolTeacher("Plamen", "Stoychev", 12, "Physics");
                    school3.ListClasses();
                    school3.HomeworksCheck();
                    school3.Fun();
                    break;
                case 4:
                    CollegeTeacher coll1 = new CollegeTeacher("Anelia", "Ivanova", 12, "Music", "122 SOU");
                    coll1.ScienceAtricle();
                    coll1.HomeworksCheck();
                    Console.WriteLine();
                    CollegeTeacher coll2 = new CollegeTeacher("Martin", "Krustev", 11, "Sports", "American College");
                    coll2.ScienceAtricle();
                    coll2.HomeworksCheck();
                    break;
                case 5:
                    Professor prof1 = new Professor("Kristian", "Rashev", 8, "University of Shumen", "PHD, St.n.s");
                    prof1.ExamsHold();
                    prof1.HomeworksCheck();
                    prof1.Lectures();
                    Console.WriteLine();
                    Professor prof2 = new Professor("Javor", "Aleksandrov", 14, "University of Sofia", "PHD, Prof.");
                    prof2.ExamsHold();
                    prof2.HomeworksCheck();
                    prof2.Lectures();
                    break;
                case 6:
                    Assistant assis1 = new Assistant("Todor", "Donev", 7, "University of Varna", true);
                    assis1.Lectures();
                    assis1.CheckExams();
                    assis1.HomeworksCheck();
                    Console.WriteLine();
                    Assistant assis2 = new Assistant("Lilia", "Tinkova", 4, "University of Varna", false);
                    assis2.Lectures();
                    assis2.CheckExams();
                    assis2.HomeworksCheck();
                    Console.WriteLine();
                    Assistant assis3 = new Assistant("Assen", "Bogdanov", 3, "University of Sofia", false);
                    assis3.Lectures();
                    assis3.CheckExams();
                    assis3.HomeworksCheck();
                    break;
                default:
                    Console.WriteLine("No such option!");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Number of objects created in this class: {0}", Person.ObjectCount);
            Console.WriteLine();
            
        }
    }
}
