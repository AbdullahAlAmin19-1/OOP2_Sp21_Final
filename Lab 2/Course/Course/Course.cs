using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Course
    {
        public string Name { set; get; }
        public String Id { set; get; }

        private Student[] students;

        public Course()
        {
            students = new Student[30];
        }

        public Course(string name, String id)
        {
            this.Name = name;
            this.Id = id;
            students = new Student[30];
        }
        
        public int StudentCount { set; get; }

        public void AddStudent(params Student[] s)
        {
            foreach (Student S in s)
            {
                if (StudentCount < 30 && S.CourseCount < 5)
                {
                    students[StudentCount++] = S;
                    if (S.GetCourse(Id) == null)
                        S.AddCourse(this);
                }
            }
        }

        public void RemoveStudent(Student s)
        {
            if (s == students[StudentCount - 1])
            {
                students[StudentCount--] = null;
                s.RemoveCourse(this);
                return;
            }
            bool found = true;
            for (int i = 0; i < StudentCount - 1; ++i)
            {
                if (s == students[i] && found)
                {
                    students[i] = null;
                    StudentCount--;
                    s.RemoveCourse(this);
                    found = false;
                }
                if (!found)
                    students[i] = students[i + 1];
            }
        }

        public Student GetStudent(String id)
        {
            for (int i = 0; i < StudentCount; ++i)
                if (id == students[i].Id)
                    return students[i];

            return null;
        }

        public void PrintStudent()
        {
            ShowCourseInfo();
            for (int i = 0; i < StudentCount; ++i)
            {
                students[i].ShowStudentInfo();
            }
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name: " + Name);
            Console.WriteLine("Course ID: " + Id);
        }
    }
}
