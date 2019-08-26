using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithEFCore.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string Name { get; set; }
    }
}
