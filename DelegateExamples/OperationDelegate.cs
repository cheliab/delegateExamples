using System;

namespace DelegateExamples
{
    /// <summary>
    /// Пример делегата с параметрами
    /// </summary>
    public class OperationDelegate
    {
        delegate int Operation(int x, int y);

        public static void Run()
        {
            // Переменная делегата
            Operation operDelegate;
            
            // Операция сложения
            operDelegate = Add;
            int addResult = operDelegate(5, 5);
            Console.WriteLine(addResult);

            operDelegate = Multiply;
            int multResult = operDelegate(3, 3);
            Console.WriteLine(multResult);
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}