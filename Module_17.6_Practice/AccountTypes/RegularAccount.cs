using System;

namespace Module_17._6_Practice
{
    public class RegularAccount : IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        // расчет процентной ставки
        public void CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;

            Console.WriteLine($"Процентная ставка обычного аккаунта равна {Interest}");
        }
    }
}
