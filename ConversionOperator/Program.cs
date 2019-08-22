using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace ConversionOperator
{
    class Program
    {
        static void ReportTypeProperties<T>(T obj)
        {
            Console.WriteLine("Compile-time type: {0}", typeof(T).Name);
            Console.WriteLine("Actual type: {0}", obj.GetType().Name);
        }
        static void Main(string[] args)
        {
            Student[] studentArray = {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
            };
            ReportTypeProperties(studentArray);
            ReportTypeProperties(studentArray.AsEnumerable());
            ReportTypeProperties(studentArray.AsQueryable());

            IList<string> strList = new List<string>() {
                "One",
                "Two",
                "Three",
                "Four",
                "Three"
            };
            string[] strArray = strList.ToArray<string>();// converts List to Array
            IList<string> list = strArray.ToList<string>(); // converts array into list

            IDictionary<int, Student> studentDict =
                studentArray.ToDictionary<Student, int>(s => s.StudentID);

            Console.Read();
        }
    }
}
