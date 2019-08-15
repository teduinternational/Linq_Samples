using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectionOperators
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public bool Gender { set; get; }
    }

    public class Employee
    {
        public int ID { get; set; }

        public string Name { set; get; }
        public List<Department> Departments { get; set; }
    }

    public class Department
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John",Gender = true},
                new Student() { StudentID = 2, StudentName = "Moin" ,Gender = true},
                new Student() { StudentID = 3, StudentName = "Bill",Gender = false },
                new Student() { StudentID = 4, StudentName = "Ram",Gender = false },
                new Student() { StudentID = 5, StudentName = "Ron",Gender = true }
            };

            //var selectedResult = from s in studentList
            //    select new
            //    {
            //        Name = (s.Gender==true? "Mr. " :"Ms.") + s.StudentName,
            //        Age = s.Age
            //    };

            var selectedResult = studentList.Select(s => new 
            {
                Name = (s.Gender == true ? "Mr. " : "Ms.") + s.StudentName,
                Age = s.Age
            });

            //foreach (var item in selectedResult)
            //    Console.WriteLine("Student Name: {0}, Age: {1}", item.Name, item.Age);


            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee
            {
                ID = 1,
                Name = "Kapil",
                Departments = new List<Department>()
                {
                    new Department { Name = "Marketing" },
                    new Department { Name = "Sales"}
                }
            });
            employees.Add(new Employee
            {
                ID = 2,
                Name = "Raj",
                Departments = new List<Department>()
                {
                    new Department { Name = "Advertisement" },
                    new Department { Name = "Production"}
                }
            });
            employees.Add(new Employee
            {
                ID = 3,
                Name = "Ramesh",
                Departments = new List<Department>()
                {
                    new Department { Name = "Production" },
                    new Department { Name = "Sales"}
                }
            });

            var result = employees.SelectMany(e => e.Departments);
            foreach (var dept in result)
            {
                Console.WriteLine(dept.Name);
            }
            Console.Read();
        }
    }
}
