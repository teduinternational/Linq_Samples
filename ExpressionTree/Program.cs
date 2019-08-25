using System;
using System.Linq.Expressions;
using Models;

namespace ExpressionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<Student, bool>> isTeenAgerExpr = s => s.Age > 12 && s.Age < 20;
            Console.WriteLine("Expression: {0}", isTeenAgerExpr);
            Console.WriteLine("Expression Type: {0}", isTeenAgerExpr.NodeType);

            var parameters = isTeenAgerExpr.Parameters;

            foreach (var param in parameters)
            {
                Console.WriteLine("Parameter Name: {0}", param.Name);
                Console.WriteLine("Parameter Type: {0}", param.Type.Name);
            }

            var bodyExpr = isTeenAgerExpr.Body as BinaryExpression;

            Console.WriteLine("Left side of body expression: {0}", bodyExpr.Left);
            Console.WriteLine("Binary Expression Type: {0}", bodyExpr.NodeType);
            Console.WriteLine("Right side of body expression: {0}", bodyExpr.Right);
            Console.WriteLine("Return Type: {0}", isTeenAgerExpr.ReturnType);

            Console.Read();
        }
    }
}
