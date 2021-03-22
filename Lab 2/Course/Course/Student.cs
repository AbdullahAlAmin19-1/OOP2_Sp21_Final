using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Student
    {
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        private float cgpa;

        public float CGPA
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        private Course[] courses;
        public Student() { this.courses = new Course[5];}
        public Student(String name, String id, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
            courses = new Course[5];
        }
        public int CourseCount { set; get;}
        public void AddCourse(params Course[] c)
        {
            foreach (Course C in c)
            {
                courses[CourseCount++] = C;

                if (C.GetStudent(id) == null)
                {
                    C.AddStudent(this);
                }  
            }
        }

        public void RemoveCourse(Course c)
        {
            bool found = true;
            for (int i = 0; i < CourseCount; ++i)
            {
                if (c == courses[i] && found)
                {
                    courses[i] = null;
                    CourseCount--;
                    c.RemoveStudent(this);
                    found = false;
                }
                if (!found)
                    courses[i] = courses[i + 1];
            }
        }


        public Course GetCourse(String id)
        {
            for (int i = 0; i < CourseCount; ++i)
                if (id == courses[i].Id)
                    return courses[i];

            return null;
        }

        public void PrintCourse()
        {
            ShowStudentInfo();
            for (int i = 0; i < CourseCount; ++i)
            {
                courses[i].ShowCourseInfo();
            }
        }
        public void ShowStudentInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID : " + id);
            Console.WriteLine("CGPA : " + cgpa);
        }
    }
}
