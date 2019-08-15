using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace SortingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            //Query
            var orderedByResult = from s in studentList
                                  orderby s.StudentName ,s.Age descending
                                  select s;

            var orderedByResult1 = studentList.OrderBy(s => s.StudentName).ThenByDescending(s=>s.Age);
            foreach (var s in orderedByResult)
            {
                Console.WriteLine(s.StudentName);
            }

            Console.Read();

        }
    }
}
