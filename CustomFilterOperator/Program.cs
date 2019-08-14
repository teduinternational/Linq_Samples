using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomFilterOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };
            var result = studentList.Filter(s => s.Age > 12);

            foreach (var student in result)
            {
                Console.WriteLine(student.StudentName);
            }

            Console.Read();
        }
    }
}
