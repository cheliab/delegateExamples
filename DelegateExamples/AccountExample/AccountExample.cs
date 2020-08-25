using System;

namespace DelegateExamples.AccountExample
{
    public class AccountExample
    {
        public static void Run()
        {
            // Создаем счет
            Account account = new Account(200);
            
            Account.AccountStateHandler ShowMessageDelegate;
            ShowMessageDelegate = ShowMessage;
            
            account.RegisterHandler(ShowMessageDelegate);
            
            account.Withdraw(100);
            account.Withdraw(20);

            account.Withdraw(90);
        }

        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}