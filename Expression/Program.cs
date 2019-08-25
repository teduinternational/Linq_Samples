using System;
using System.Linq.Expressions;

namespace Expression
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Func<Student, bool> isTeenAger = s => s.Age > 12 && s.Age < 20;
            Expression<Func<Student, bool>> isTeenAgerExpr = s => isTeenAger(s);

            Func<Student, bool> isTeenAgerComplied = isTeenAgerExpr.Compile();

            //Invoke
            bool result = isTeenAgerComplied(new Student() { StudentID = 1, StudentName = "Steve", Age = 20 });

            Expression<Action<Student>> printStudentName = s => Console.WriteLine(s.StudentName);


            Console.WriteLine("Hello World!");
        }
    }
}
