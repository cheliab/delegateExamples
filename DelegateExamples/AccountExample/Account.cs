namespace DelegateExamples.AccountExample
{
    /// <summary>
    /// Банковский счет
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Сумма на счету
        /// </summary>
        private int sum;

        /// <summary>
        /// Делегат для получения состояния счета
        /// </summary>
        /// <param name="message"></param>
        public delegate void AccountStateHandler(string message);

        private AccountStateHandler _accountStateHandler;

        public int Sum
        {
            get => sum;
        }

        public Account(int sum)
        {
            this.sum = sum;
        }

        /// <summary>
        /// Добавить сумму на счет
        /// </summary>
        /// <param name="sum"></param>
        public void Put(int sum)
        {
            this.sum += sum;
        }

        /// <summary>
        /// Снять деньги со счета
        /// </summary>
        /// <param name="sum"></param>
        public void Withdraw(int sum)
        {
            if (this.sum > sum)
            {
                this.sum -= sum;
                
                _accountStateHandler?.Invoke($"Сумма {sum} снята со счета");
            }
            else
            {
                _accountStateHandler?.Invoke("Не достаточно денег на счете");
            }
        }

        public void RegisterHandler(AccountStateHandler newAccountStateHandler)
        {
            _accountStateHandler = newAccountStateHandler;
        }
    }
}