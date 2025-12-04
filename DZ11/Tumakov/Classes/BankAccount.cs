using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Tumakov.Enums;

namespace Tumakov.Classes
{
    class BankAccount
    {
        public Guid Id { get; private set; }
        public decimal Balance { get; private set; }
        public TypeBankAccount Type { get; private set; }
        public string Holder {  get; set; }
        public List<BankTransaction> TransactionsInBAccount { get; } = new List<BankTransaction>();

        public BankAccount(decimal balance, TypeBankAccount type, string holder)
        {
            Id = Guid.NewGuid();
            Balance = balance >= 0m ? balance : 0m;
            Type = type;
            Holder = holder;
        }

        public BankAccount(decimal balance, TypeBankAccount type)
        {
            Id = Guid.NewGuid();
            Balance = balance >= 0m ? balance : 0m;
            Type = type;
            Holder = "Unknown";
        }

        public BankAccount(decimal balance)
        {
            Id = Guid.NewGuid();
            Balance = balance >= 0m ? balance : 0m;
            Type = TypeBankAccount.Current; //по умолчанию Current
            Holder = "Unknown";
        }

        public BankAccount(TypeBankAccount type)
        {
            Id = Guid.NewGuid();
            Balance = 0m;
            Type = type;
            Holder = "Unknown";
        }

        public BankAccount()
        {
            Id = Guid.NewGuid();
            Balance = 0m;
            Type = TypeBankAccount.Current;
            Holder = "Unknown";
        }

        public BankAccount(string holder)
        {
            Id = Guid.NewGuid();
            Balance = 0m;
            Type = TypeBankAccount.Current;
            Holder = holder;
        }

        public BankTransaction this[int index]
        {
            get 
            {
                if (index >= 0 || index < TransactionsInBAccount.Count)
                {
                    return TransactionsInBAccount[index];
                }
                throw new IndexOutOfRangeException();
            }
        }

        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine("\n--- Метод DumpToScreen ---");
            Console.WriteLine($"Банковский счет #{Id}");
            Console.WriteLine($"Баланс: {Balance}\nТип: {Type}\nДержатель: {Holder}");
        }

        public bool WithdrawFromBA(decimal money)
        {
            if (Balance >= money && money > 0m)
            {
                TransactionsInBAccount.Add(new BankTransaction(money * (-1)));
                Balance -= money;
                Console.WriteLine($"-------------\nУспешно. Со счета {Id} снялось {money} руб.");
                return true;
            }
            else
            {
                Console.WriteLine($"-------------\nНедостаточно средств на счету {Id}.");
                return false;
            }
        }

        public void DepositIntoBA(decimal money)
        {
            if (money > 0m)
            {
                TransactionsInBAccount.Add(new BankTransaction(money));
                Balance += money;
                Console.WriteLine($"-------------\nУспешно. Счет {Id} пополнен на {money} руб.");
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
                File.AppendAllText(@"..\..\Files\BankAccountTransactions.txt", $"{transaction.ChangesInAccount}, {transaction.Date}\n");
            }
            GC.SuppressFinalize(this);
        }

    }
}