using System;
using Tumakov.Enums;

namespace Tumakov.Classes
{
    class BankAccount
    {
        protected int Number;
        protected decimal Balance;
        protected TypeBankAccount Type;
        protected static int IncreasingNumber = 1;
        protected static int NumberChange()
        {
            return IncreasingNumber++;
        }

        public void PrintInfoBA()
        {
            Console.WriteLine($"-------------\nИнформация о карте.\nНомер: {Number}\nБаланс: {Balance}\nТип: {Type}\n");
        }
        public object[] GetInfo() //Получение значений
        {
            return new object[3] { Number, Balance, Type };
        }

        public BankAccount(decimal balance, TypeBankAccount type)
        {
            Number = NumberChange();
            Balance = balance;
            Type = type;
        }
        public bool WithdrawFromBA(decimal money)
        {
            if (Balance >= money)
            {
                Balance -= money;
                Console.WriteLine($"-------------\nУспешно. Со счета {Number} снялось {money} руб.");
                return true;
            }
            else
            {
                Console.WriteLine($"-------------\nНедостаточно средств на счету {Number}.");
                return false;
            }
        }
        public void DepositIntoBA(decimal money)
        {
            Balance += money;
            Console.WriteLine($"-------------\nУспешно. Счет {Number} пополнен на {money} руб.");
        }
        public void MoneyTransfer(BankAccount bankAccount, decimal money)
        {
            if (bankAccount.WithdrawFromBA(money))
            {
                DepositIntoBA(money);
            }
            else
            {
                Console.WriteLine("Операция перевода денег неудачна.");
            }
        }
    }
}