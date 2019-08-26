using System;
using System.Collections.Generic;
using System.Linq;
using WorkingWithEFCore.Models;

namespace WorkingWithEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                //context.Courses.AddRange(new List<Course>()
                //{
                //    new Course(){CourseName = "Math"},
                //    new Course(){CourseName = "History"},
                //});
                //context.Students.AddRange(new List<Student>()
                //{
                //    new Student(){CourseId = 1, Name = "Bill"},
                //    new Student(){CourseId = 2, Name = "Peter"},
                //});
                //context.SaveChanges();

                var students = from s in context.Students
                    join c in context.Courses on s.CourseId equals c.CourseId
                    select new
                    {
                        StudentName = s.Name,
                        CourseName = c.CourseName
                    };
                foreach (var s in students)
                {
                    Console.WriteLine("Student name: " + s.StudentName + ". Course name: " + s.CourseName);
                }

                Console.Read();
            }
        }
    }
}
