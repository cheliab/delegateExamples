using System;

namespace DelegateExamples.EventExample
{
    public class EventExample
    {
        public static void Run()
        {
            var account = new Account(100);

            account.Notify += DisplayMessage;
            
            account.Put(10);

            account.Notify -= DisplayMessage;
            
            account.Put(40);
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        private class Account
        {
            public delegate void AccountHandler(string message);
            public event AccountHandler Notify;
            
            public int Sum { get; private set; }
            
            public Account(int sum)
            {
                Sum = sum;
            }

            public void Put(int sum)
            {
                Sum += sum;

                Notify?.Invoke($"Добавлено на счет {sum}. Текущий баланс {Sum}");
            }
        }
    }
}