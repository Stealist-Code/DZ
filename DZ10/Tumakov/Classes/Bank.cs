using System;
using System.Collections;
using Tumakov.Enums;

namespace Tumakov.Classes
{
    public class Bank
    {
        private Hashtable accounts = new Hashtable();

        public long CreateAccount()
        {
            BankAccount newBAccount = new BankAccount();
            accounts[newBAccount.Number] = newBAccount;
            return newBAccount.Number;
        }

        public long CreateAccount(decimal balance)
        {
            BankAccount newAccount = new BankAccount(balance);
            accounts[newAccount.Number] = newAccount;
            return newAccount.Number;
        }

        public long CreateAccount(decimal balance, TypeBankAccount type)
        {
            BankAccount newAccount = new BankAccount(balance, type);
            accounts[newAccount.Number] = newAccount;
            return newAccount.Number;
        }

        public void CloseAccount(long accountNumber)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                accounts.Remove(accountNumber);
                Console.WriteLine("\nУспешно. Счет удалился");
                return;
            }
            Console.WriteLine("\nНеуспешно. Счет не получилось удалить");
        }
        public BankAccount GetAccount(long accountNumber)
        {
            return accounts[accountNumber] as BankAccount;
        }
    }
}
