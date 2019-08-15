using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace GroupingOperators
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
                new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }
            };

            //var grouptedResult = from s in studentList
            //    group s by s.Age;

            // grouptedResult = studentList.GroupBy(s => s.Age);

            var grouptedResult = studentList.ToLookup(s => s.Age);

            foreach (var ageGroup in grouptedResult)
            {
                Console.WriteLine("Age: {0}",ageGroup.Key);

                foreach (var s in ageGroup)
                {
                    Console.WriteLine("Student name: {0}",s.StudentName);
                }
            }

            Console.Read();
        }
    }
}
