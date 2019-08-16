using System;
using System.Collections.Generic;
using System.Linq;

namespace ElementOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };

            IList<string> strList = new List<string>() { "One", "Two", null, "Four", "Five" };

            Console.WriteLine("1st Element in intList: {0}", intList.ElementAt(0));
            Console.WriteLine("1st Element in strList: {0}", strList.ElementAt(0));

            Console.WriteLine("10th Element in intList: {0} - default int value",
                intList.ElementAtOrDefault(9));
            Console.WriteLine("10th Element in strList: {0} - default string value (null)",
                strList.ElementAtOrDefault(9));

            Console.WriteLine("1st Element in intList: {0}", intList.OrderByDescending(s => s).First(i => i % 2 == 0));

            Console.WriteLine("Last Element in intList: {0}", intList.OrderByDescending(s => s).LastOrDefault(i => i >100));

            IList<int> oneElementList = new List<int>() { 7 };
            Console.WriteLine("The only element in oneElementList: {0}", oneElementList.Single());

            Console.WriteLine("The only element which is less than 20: {0}", intList.Single(s=>s < 20));
            Console.Read();
        }
    }
}
