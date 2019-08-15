using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace AggregationOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };
            var commaSeparatedString = strList.Aggregate((s1, s2)=> s1 + "- " + s2);
            Console.WriteLine(commaSeparatedString);

            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron", Age = 15 }
            };

            var commaSeparatedStudentNames =
                studentList.Aggregate<Student, string>("Names: ", (str, s) => str += s.StudentName + ", ");
            //Console.WriteLine(commaSeparatedStudentNames);


            IList<int> intList = new List<int> () { 10, 20, 30 };
            var avg = intList.Average();
            var max = intList.Max();
            var min = intList.Min();
            var sum = intList.Sum();
            Console.WriteLine("Min: {0}, Max: {1}, Sum: {2}, Avg: {3}",min,max,sum,avg);

            var avgAge = studentList.Average(s => s.Age);

            Console.WriteLine("Average Age of Student: {0}", avgAge);
            Console.Read();
        }
    }
}
