using System;
using System.Net.NetworkInformation;
using System.Text;

namespace DelegateExamples
{
    /// <summary>
    /// Пример использования делегата как пераметра метода
    /// </summary>
    public class DelegateAsParameter
    {
        delegate void Message();

        public static void Run()
        {
            if (DateTime.Now.Hour < 12)
            {
                ShowMessage(GoodMorning);
            }
            else
            {
                ShowMessage(GoodEvening);
            }
        }

        private static void ShowMessage(Message messageDelegate)
        {
            messageDelegate?.Invoke();
        }

        private static void GoodMorning()
        {
            Console.WriteLine("Good morning");
        }

        private static void GoodEvening()
        {
            Console.WriteLine("Good evening");
        }
    }
}