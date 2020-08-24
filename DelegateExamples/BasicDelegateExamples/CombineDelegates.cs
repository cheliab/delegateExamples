using System;

namespace DelegateExamples
{
    /// <summary>
    /// Пример объединения делегатов
    /// </summary>
    public class CombineDelegates
    {
        delegate void Message();

        public static void Run()
        {
            Message messageHello = Hello;
            Message messageHowAreYou = HowAreYou;
            Message messageBye = Bye;

            // Объединяем делегаты
            Message messageCombine = messageHello + messageHowAreYou + messageBye;

            // Вызов всех методов
            messageCombine();
        }

        private static void Hello()
        {
            Console.WriteLine("Hello!");
        }

        private static void HowAreYou()
        {
            Console.WriteLine("How are you?");
        }

        private static void Bye()
        {
            Console.WriteLine("Bye bye!");
        }
    }
}