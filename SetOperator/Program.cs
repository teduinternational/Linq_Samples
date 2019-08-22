using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOperator
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID
                && x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.StudentID.GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //IList<string> strList = new List<string>() { "One", "Two", "Three", "Two", "Three" };

            //var distinctList1 = strList.Distinct();

            //foreach (var str in distinctList1)
            //    Console.WriteLine(str);


            //IList<Student> studentList = new List<Student>() {
            //    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            //    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            //    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            //};
            //var distinctStudents = studentList.Distinct(new StudentComparer());

            //foreach (Student std in distinctStudents)
            //    Console.WriteLine(std.StudentName);

            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };
            //var result = strList1.Except(strList2);
            var result1 = strList1.Intersect(strList2);
            var result2 = strList1.Union(strList2);
            //foreach (string str in result)
            //    Console.WriteLine(str);

            //foreach (string str in result1)
            //    Console.WriteLine(str);

            foreach (string str in result2)
                Console.WriteLine(str);
            Console.Read();
        }
    }
}
