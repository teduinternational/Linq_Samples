using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace ImmediateExecution
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 12 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

            //IList<Student> teenAgerStudents =
            //    studentList.Where(s => s.Age > 12 && s.Age < 20).ToList();

            var teenAgerStudents = (from s in studentList
                where s.Age > 12 && s.Age < 20
                select s).ToList();

            Console.WriteLine("Hello World!");
        }
    }
}
