using System;
using System.Collections.Generic;
using System.Linq;

namespace PartitioningOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> strList = new List<string>() { "Three","One", "Two" , "Four", "Five","Six" };
            var newList = strList.Skip(2);
            //foreach (var str in newList)
            //    Console.WriteLine(str);

            //Skip while
            var resultList = strList.SkipWhile(s => s.Length < 4);
            //foreach (string str in resultList)
            //    Console.WriteLine(str);
            //Take
            var newList1 = strList.Take(2);

            //foreach (var str in newList1)
            //    Console.WriteLine(str);

            var result = strList.TakeWhile(s => s.Length > 4);

            //foreach (string str in result)
            //    Console.WriteLine(str);

            int page = 3;
            int pageSize = 2;
            var pagedList = strList.Skip((page - 1) * pageSize).Take(pageSize);

            foreach (string str in pagedList)
                Console.WriteLine(str);
            Console.Read();
        }
    }
}
