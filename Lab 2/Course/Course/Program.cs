using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Abdullah", "S12345", 3.50f);
            Student s2 = new Student("Al Amin", "S12345", 3.00f);
            Student s3 = new Student("Noman", "S12345", 3.50f);

            Course c1 = new Course("C", "CSE001");
            Course c2 = new Course("C++", "CSE002");


            c2.AddStudent(s1, s3);
            c2.PrintStudent();
            c2.RemoveStudent(s1);

            Console.WriteLine("####################");

            s1.PrintCourse();
            Console.WriteLine("####################");
            c2.PrintStudent();

            Console.WriteLine("####################");

            s2.AddCourse( c1, c2);
            s2.PrintCourse();
            s2.RemoveCourse(c1);

            Console.WriteLine("####################");
            
            s2.PrintCourse();
            Console.WriteLine("####################");
            c1.PrintStudent();
        }
    }
}
