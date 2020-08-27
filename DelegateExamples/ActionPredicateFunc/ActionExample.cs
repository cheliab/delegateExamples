using System;

namespace DelegateExamples.ActionPredicateFunc
{
    public class ActionExample
    {
        public static void Run()
        {
            Action<int, int> operation;

            operation = Add;
            OperationRun(10, 5, operation);

            operation = Subtract;
            OperationRun(10, 5, operation);
        }
        
        private static void OperationRun(int x, int y, Action<int, int> operation)
        {
            if (x > y)
                operation(x, y);
        }

        private static void Add(int x, int y)
        {
            var result = x + y;
            
            Console.WriteLine($"Сумма чисел: {result}");
        }

        private static void Subtract(int x, int y)
        {
            var result = x - y;
            
            Console.WriteLine($"Разность чисел: {result}");
        }
    }
}