using System;

namespace Module_17._6_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var handlerAccount = new HandlerAccount();

            handlerAccount.SelectAccountByType(new RegularAccount() { Balance = 70000 });

            Console.WriteLine();

            handlerAccount.SelectAccountByType(new SalaryAccount() { Balance = 10000 });

            Console.ReadLine();
        }
    }
}
