using System;
using System.Collections.Generic;
using ExtensionMethods.Extensions;


namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee() { Id = 1, Name = "A"},
                new Employee() { Id = 2, Name = "B"},
            };
           
            Console.WriteLine(developers.Count());
            Console.Read();
        }
    }
}
