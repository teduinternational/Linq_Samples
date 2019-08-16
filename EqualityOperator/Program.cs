using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace EqualityOperator
{
    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

            IList<string> strList2 = new List<string>() {  "Two", "One", "Three", "Four", "Three" };

            bool isEqual = strList1.SequenceEqual(strList2); // returns true
            Console.WriteLine(isEqual);


            Student std = new Student() { StudentID = 1, StudentName = "Bill" };
            IList<Student> studentList1 = new List<Student>() { std };

            IList<Student> studentList2 = new List<Student>() { std };
            bool studentEqual = studentList1.SequenceEqual(studentList2); // returns true


            Student std1 = new Student() { StudentID = 1, StudentName = "Bill" };
            Student std2 = new Student() { StudentID = 1, StudentName = "Bill" };

            IList<Student> studentList3 = new List<Student>() { std1 };

            IList<Student> studentList4 = new List<Student>() { std2 };

            isEqual = studentList3.SequenceEqual(studentList4);// returns false

            IList<Student> studentListA = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            IList<Student> studentListB = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            // following returns true
            isEqual = studentListA.SequenceEqual(studentListA, new StudentComparer());
            Console.Read();
        }
    }
}
