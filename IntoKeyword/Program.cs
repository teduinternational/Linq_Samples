using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace IntoKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

            var teenAgerStudents = from s in studentList
                where s.Age > 12 && s.Age < 20
                select s
                into teenStudents
                where teenStudents.StudentName.StartsWith("B")
                select teenStudents;

        }
    }
}
