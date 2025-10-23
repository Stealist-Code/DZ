using System;
using Tumakov.Enums;

namespace Tumakov.Classes
{
    class BankAccount
    {
        protected int Number;
        protected decimal Balance;
        protected TypeBankAccount Type;

        public void PrintInfoBA()
        {
            Console.WriteLine($"-------------\nИнформация о карте.\nНомер: {Number}\nБаланс: {Balance}\nТип: {Type}\n");
        }
        public object[] GetInfo() //Получение значений
        {
            return new object[3] { Number, Balance, Type };
        }

        public BankAccount(int number, decimal balance, TypeBankAccount type)
        {
            Number = number;
            Balance = balance;
            Type = type;
        }
    }
}
