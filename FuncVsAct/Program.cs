using System;

namespace FuncVsAct
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> myAction = new Action<int>(DoSomething);
            myAction(123);

            Func<int,double> myFunc = new Func<int, double>(CalculateSomething);
            Console.WriteLine(myFunc(5));
            Console.Read();
        }

        static void DoSomething(int i)
        {
            Console.WriteLine(i);
        }

        static double CalculateSomething(int i)
        {
            return (double) i / 2;
        }
    }
}
