using System;
using System.Collections;
using BankAccountLibrary.Enums;

namespace BankAccountLibrary.Classes
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

        public bool CloseAccount(long accountNumber)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                accounts.Remove(accountNumber);
                return true;
            }
            return false;
        }
        public BankAccount GetAccount(long accountNumber)
        {
            return accounts[accountNumber] as BankAccount;
        }
    }
}
