using System;
using BankAccountLibrary.Enums;

namespace BankAccountLibrary.Classes
{
    public class BankAccount
    {
        public long Number { get; private set; }
        public decimal Balance { get; set; }
        public TypeBankAccount Type { get; protected set; }
        protected static int IncreasingNumber = 1;
        protected static int NumberChange()
        {
            return IncreasingNumber++;
        }

        public void PrintInfoBA()
        {
            Console.WriteLine($"\n--- Информация о карте. ---\nНомер: {Number}\nБаланс: {Balance}\nТип: {Type}");
        }

        internal BankAccount(decimal balance, TypeBankAccount type)
        {
            Number = NumberChange();
            Balance = balance >= 0m ? balance : 0m;
            Type = type;
        }
        internal BankAccount(decimal balance)
        {
            Number = NumberChange();
            Balance = balance >= 0m ? balance : 0m;
            Type = TypeBankAccount.Current; //по умолчанию Current
        }
        internal BankAccount(TypeBankAccount type)
        {
            Number = NumberChange();
            Balance = 0m;
            Type = type;
        }
        internal BankAccount()
        {
            Number = NumberChange();
            Balance = 0m;
            Type = TypeBankAccount.Current;
        }
        public bool WithdrawFromBA(decimal money)
        {
            if (Balance >= money && money > 0m)
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
            if (money > 0m)
            {
                Balance += money;
                Console.WriteLine($"-------------\nУспешно. Счет {Number} пополнен на {money} руб.");
            }
            else
            {
                Console.WriteLine("-------------\nНельзя пополнить счет на 0 или меньшее количество монет.");
            }
        }
    }
}
