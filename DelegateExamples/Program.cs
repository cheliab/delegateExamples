using System;

namespace DelegateExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleDelegate.Run();
            
            Console.WriteLine(new string('-', 40));
            
            OperationDelegate.Run();
            
            Console.ReadLine();
        }
    }
}