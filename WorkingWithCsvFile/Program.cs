using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WorkingWithCsvFile
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> strCsv = File.ReadAllLines("Sample.csv");

            var result = from str in strCsv
                let tmp = str.Split(",").Skip(1).Select(s => Convert.ToInt32(s))
                select new
                {
                    Max = tmp.Max(),
                    Min = tmp.Min(),
                    Total = tmp.Sum(),
                    Avg = tmp.Average()
                };
            var query = result.ToList();
            foreach (var x in query)
            {
                Console.WriteLine(
                    $"Maximum: {x.Max}, " + $"Minimum: {x.Min}, " + $"Total: {x.Total}, " + $"Average: {x.Avg}");
            }

            Console.Read();
        }
    }
}
