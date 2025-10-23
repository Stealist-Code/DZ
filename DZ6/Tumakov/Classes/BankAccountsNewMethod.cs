using System;
using Tumakov.Enums;

namespace Tumakov.Classes
{
    class BankAccountNewMethod : BankAccountChanged
    {
        public BankAccountNewMethod(decimal balance, TypeBankAccount type) : base(balance, type) { }
        public void WithdrawFromBA(decimal money)
        {
            if (Balance >= money)
            {
                Balance -= money;
                Console.WriteLine($"-------------\nУспешно. Со счета снялось {money} руб.");
            }
            else
            {
                Console.WriteLine("-------------\nНедостаточно средств.");
            }
        }
        public void DepositIntoBA(decimal money)
        {
            Balance += money;
            Console.WriteLine($"-------------\nУспешно. Счет пополнен на {money} руб.");
        }
    }
}
