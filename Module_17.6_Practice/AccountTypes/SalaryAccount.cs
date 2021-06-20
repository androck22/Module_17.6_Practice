using System;

namespace Module_17._6_Practice
{
    class SalaryAccount : IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        // расчет процентной ставки
        public void CalculateInterest()
        {
            Interest = Balance * 0.5;

            Console.WriteLine($"Процентная ставка зарплатного аккаунта равна {Interest}");
        }
    }
}
