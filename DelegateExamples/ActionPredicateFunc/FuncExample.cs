using System;

namespace DelegateExamples.ActionPredicateFunc
{
    public class FuncExample
    {
        public static void Run()
        {
            Func<int, int> returnFunc = Factorial;
            int result = GetInt(5, returnFunc);
            Console.WriteLine(result);

            int resultLambda = GetInt(5, x => x * x);
            Console.WriteLine(resultLambda);
        }

        private static int GetInt(int x, Func<int, int> returnFunc)
        {
            int result = 0;

            if (x > 0)
                result = returnFunc(x);

            return result;
        }

        private static int Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}