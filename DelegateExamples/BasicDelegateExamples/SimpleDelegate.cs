using System;

namespace DelegateExamples
{
    /// <summary>
    /// Пример простого делегата 
    /// </summary>
    public class SimpleDelegate
    {
        /// <summary>
        /// Делегат без принимаемых и возвращаемых параметров
        /// </summary>
        delegate void Message();

        public static void Run()
        {
            // Переменная типа делегата
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