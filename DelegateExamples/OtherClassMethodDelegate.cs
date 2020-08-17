using System;

namespace DelegateExamples
{
    /// <summary>
    /// Пример использвания метода другого класса
    /// </summary>
    
    class Math
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
    
    public class OtherClassMethodDelegate
    {
        delegate int Operation(int x, int y);

        static void Run()
        {
            Operation operDelegate;
            
            Math math = new Math();
            operDelegate = math.Sum;

            int result = operDelegate(2, 2);

            Console.WriteLine(result);
        }
    }
}