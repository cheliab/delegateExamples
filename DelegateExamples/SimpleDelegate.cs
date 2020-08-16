using System;

namespace DelegateExamples
{
    public class SimpleDelegate
    {
        delegate void Message();

        public static void Run()
        {
            Message message;

            if (DateTime.Now.Hour < 12)
            {
                message = GoodMorning;
            }
            else
            {
                message = GoodAfternoon;
            }

            message();
        }

        private static void GoodMorning()
        {
            Console.WriteLine("Доброе утро, братан!");
        }

        private static void GoodAfternoon()
        {
            Console.WriteLine("Добрый день, братан!");
        }
    }
}