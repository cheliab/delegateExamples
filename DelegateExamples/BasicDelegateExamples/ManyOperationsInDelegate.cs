using System;

namespace DelegateExamples
{
    /// <summary>
    /// Пример:
    /// возвращается только последнее значение,
    /// если несколько методов в делегате возвращают значения 
    /// </summary>
    public class ManyOperationsInDelegate
    {
        delegate int Operation(int x, int y);

        public static void Run()
        {
            Operation manyOperations;
            manyOperations = Subtract;
            manyOperations += Multiply;
            manyOperations += Add;

            var resultOp = manyOperations(7, 2); // Вернется 9 / Add(7, 2)
            
            Console.WriteLine(resultOp);
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static int Subtract(int x, int y)
        {
            return x - y;
        }

        private static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}