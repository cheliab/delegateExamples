using System;

namespace DelegateExamples
{
    class Program
    {
        private static void BasicDelegateExamples()
        {
            Console.WriteLine(new string('-', 40));
            
            SimpleDelegate.Run();
            
            Console.WriteLine(new string('-', 40));
            
            OperationDelegate.Run();
            
            Console.WriteLine(new string('-', 40));
            
            MultipleMethodsInDelegate.Run();
            
            Console.WriteLine(new string('-', 40));
            
            CombineDelegates.Run();
            
            Console.WriteLine(new string('-', 40));
            
            UseInvokeExample.Run();
            
            Console.WriteLine(new string('-', 40));
            
            ManyOperationsInDelegate.Run();

            Console.WriteLine(new string('-', 40));
            
            DelegateAsParameter.Run();

            Console.WriteLine(new string('-', 40));
            
            GenericDelegate.Run();
        }
        
        static void Main(string[] args)
        {
            AccountExample.AccountExample.Run();
            
            Console.ReadLine();
        }
    }
}