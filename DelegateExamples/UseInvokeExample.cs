using System;

namespace DelegateExamples
{
    /// <summary>
    /// Пример использования Invoke для вызова делегата
    /// </summary>
    public class UseInvokeExample
    {
        delegate int Operation(int x, int y);
        delegate void Message();

        public static void Run()
        {
            Message messageHello = Hello;
            messageHello.Invoke();

            Operation operationAdd = Add;
            var resOp = operationAdd.Invoke(2, 3);
            Console.WriteLine(resOp);
            
            // Пример пустого делегата
            Message nullExaple = null;
            nullExaple?.Invoke();
            
            // nullExaple(); // Возникнет исключение
        }

        private static void Hello()
        {
            Console.WriteLine("Hello");
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }
    }
}