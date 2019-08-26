using System;
using System.Linq;
using System.Xml.Linq;

namespace WorkingWithXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement xElement = XElement.Load("Employees.xml");
            var employees = from x in xElement.Elements("Employee")
                            let city = x.Element("Address")?.Element("City")
                            where (string)city == "Alta"
                            orderby city descending
                            select x;

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Element("Name")?.Value);
                Console.WriteLine(employee.Element("EmpId")?.Value);
            }
            Console.Read();
        }
    }
}
