using System;

namespace Module_17._6_Practice
{
    interface IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        // расчет процентной ставки
        void CalculateInterest();
    }
}
