using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Tumakov.Classes;
using Tumakov.Enums;

namespace Tumakov.Classes
{
    class BankAccount
    {
        public int Number { get; protected set; }
        public decimal Balance { get; protected set; }
        public TypeBankAccount Type { get; protected set; }
        public Queue<BankTransaction> TransactionsInBAccount { get;} = new Queue<BankTransaction>();
        protected static int IncreasingNumber = 1;
        protected static int NumberChange()
        {
            return IncreasingNumber++;
        }

        public void PrintInfoBA()
        {
            Console.WriteLine($"\n--- Информация о карте. ---\nНомер: {Number}\nБаланс: {Balance}\nТип: {Type}");
        }

        public BankAccount(decimal balance, TypeBankAccount type)
        {
            Number = NumberChange();
            Balance = balance >= 0m ? balance : 0m;
            Type = type;
        }
        public BankAccount(decimal balance)
        {
            Number = NumberChange();
            Balance = balance >= 0m ? balance : 0m;
            Type = TypeBankAccount.Current; //по умолчанию Current
        }
        public BankAccount(TypeBankAccount type)
        {
            Number = NumberChange();
            Balance = 0m;
            Type = type;
        }
        public bool WithdrawFromBA(decimal money)
        {
            if (Balance >= money && money > 0m)
            {
                TransactionsInBAccount.Enqueue(new BankTransaction(money * (-1)));
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
                TransactionsInBAccount.Enqueue(new BankTransaction(money));
                Balance += money;
                Console.WriteLine($"-------------\nУспешно. Счет {Number} пополнен на {money} руб.");
            }
            else
            {
                Console.WriteLine("-------------\nНельзя пополнить счет на 0 или меньшее количество монет.");
            }
        }
        public void MoneyTransfer(BankAccount bankAccount, decimal money)
        {
            if (WithdrawFromBA(money))
            {
                bankAccount.DepositIntoBA(money);
            }
            else
            {
                Console.WriteLine("Операция перевода денег неудачна.");
            }
        }

        public void Dispose()
        {
            foreach (var transaction in TransactionsInBAccount)
            {
                File.AppendAllText(@"..\..\Files\Text.txt", $"{transaction.ChangesInAccount}, {transaction.Date}\n");
            }
            GC.SuppressFinalize(this);
        }
        
    }
}