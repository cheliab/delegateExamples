using System;

namespace DelegateExamples
{
    public class MultipleMethodsInDelegate
    {
        delegate void Message();

        public static void Run()
        {
            Message messageDelegate;

            messageDelegate = Hello;
            messageDelegate += HowAreYou;

            messageDelegate();
        }

        private static void Hello()
        {
            Console.WriteLine("Hello");
        }

        private static void HowAreYou()
        {
            Console.WriteLine("How are you?");
        }
    }
}