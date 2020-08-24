using System;

namespace DelegateExamples
{
    /// <summary>
    /// Присвоение ссылки на метод используя конструктор делегата
    /// </summary>
    public class UseDelegateConstructor
    {
        delegate int Operation(int x, int y);

        public static void Run()
        {
            Operation operationAdd = new Operation(Add);
            int result = operationAdd(3, 7);
            
            Console.WriteLine(result);
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }
    }
}