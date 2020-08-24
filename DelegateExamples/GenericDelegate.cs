using System;

namespace DelegateExamples
{
    delegate T Operation<T, K>(K val);
    
    /// <summary>
    /// Пример обобщенных делегатов
    /// </summary>
    public class GenericDelegate
    {
        public static void Run()
        {
            Operation<decimal, int> op = Square;
            
            Console.WriteLine(op(5));

            Operation<string, string> opString = AddDotToSting;

            Console.WriteLine(opString("Hello"));
        }

        private static decimal Square(int n)
        {
            return n * n;
        }

        private static string AddDotToSting(string message)
        {
            return $"{message}.";
        }
    }
}