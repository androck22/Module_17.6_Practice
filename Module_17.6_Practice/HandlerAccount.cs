using System;

namespace Module_17._6_Practice
{
    class HandlerAccount
    {
        /// <summary>
        /// Выбирает аккаунт по типу
        /// </summary>
        public void SelectAccountByType(IAccount accountType)
        {
            accountType.CalculateInterest();
        }
    }
}
