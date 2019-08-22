using System;
using System.Collections.Generic;
using System.Linq;

namespace GenerationOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> emptyList = new List<string>();
            var newList1 = emptyList.DefaultIfEmpty();
            var newList2 = emptyList.DefaultIfEmpty("None");

            Console.WriteLine("Count: {0}", newList1.Count());
            Console.WriteLine("Value: {0}", newList1.ElementAt(0));

            Console.WriteLine("Count: {0}", newList2.Count());
            Console.WriteLine("Value: {0}", newList2.ElementAt(0));

            var emptyCollection1 = Enumerable.Empty<string>();
            Console.WriteLine("Count: {0} ", emptyCollection1.Count());

            var intCollection = Enumerable.Range(10, 10);
            for (int i = 0; i < intCollection.Count(); i++)
                Console.WriteLine("Value at index {0} : {1}", i, intCollection.ElementAt(i));

            var intCollection1 = Enumerable.Repeat<string>("test", 10);
            for (int i = 0; i < intCollection1.Count(); i++)
                Console.WriteLine("Value at index {0} : {1}", i, intCollection1.ElementAt(i));
            Console.Read();
        }
    }
}
