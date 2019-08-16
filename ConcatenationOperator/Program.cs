using System;
using System.Collections.Generic;
using System.Linq;

namespace ConcatenationOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> collection1 = new List<string>() { "One", "Two", "Three" };
            IList<string> collection2 = new List<string>() { "Five", "Six" };

            var collection3 = collection1.Concat(collection2);
            foreach (string str in collection3)
                Console.WriteLine(str);
            Console.Read();
        }
    }
}
