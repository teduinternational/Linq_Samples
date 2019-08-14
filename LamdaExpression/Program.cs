using System;
using System.Collections.Generic;
using System.Linq;

namespace LamdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee() { Id = 1, Name = "Alex"},
                new Employee() { Id = 2, Name = "Bary"},
            };
            foreach (var employee in developers.Where(employee => employee.Name.StartsWith("A")))
            {
                Console.WriteLine(employee.Name);
            }
            Console.Read();
        }

        private static bool NameStartWithA(Employee employee)
        {
            return employee.Name.StartsWith("A");
        }
    }
}
