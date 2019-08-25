using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace LetKeyword
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

            var lowercaseStudentNames = from s in studentList
                let lowercaseStudentName= s.StudentName.ToLower()
                where lowercaseStudentName.StartsWith("r")
                select lowercaseStudentName;

            foreach (var name in lowercaseStudentNames)
                Console.WriteLine(name);

            Console.WriteLine("Hello World!");
        }
    }
}
