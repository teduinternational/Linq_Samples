using System;
using System.Linq;

namespace Example1
{
    class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray = {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 },
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
                new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
                new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
            };

            //Student[] students = new Student[7];
            //int i = 0;
            //foreach (var student in studentArray)
            //{
            //    if (student.Age > 12 && student.Age < 20)
            //    {
            //        students[i] = student;
            //        i++;
            //    }
            //}

        
            Student[] students = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

            Console.WriteLine("Total student have age from 12 to 20:" + students.Length);
            Console.Read();
        }
    }
}
