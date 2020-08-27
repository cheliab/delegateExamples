using System;

namespace DelegateExamples.ActionPredicateFunc
{
    public class PredicateExample
    {
        public static void Run()
        {
            Predicate<int> isPositive = delegate(int x) { return x > 0; };
            Predicate<int> isNegative = x => x < 0;
            
            Console.WriteLine(isPositive(20));
            Console.WriteLine(isPositive(-20));

            Console.WriteLine(isNegative(10));
            Console.WriteLine(isNegative(-10));
        }
    }
}