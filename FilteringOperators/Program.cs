using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FilteringOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };
            IEnumerable<string> filteredResult = from s in studentList
                                                 where s.Age > 12
                                                 where s.Age > 20
                                                 select s.StudentName;

            var filteredResult1 = studentList.Where(s => s.Age > 12).Where(s=>s.Age < 20);


            //OfType
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });


            var stringResullt = from s in mixedList.OfType<string>()
                select s;
            foreach (var s in stringResullt)
            {
                Console.WriteLine(s);
            }

            var intResult = from s in mixedList.OfType<int>()
                select s;

            foreach (var i in intResult)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
