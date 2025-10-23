using System;
using Tumakov.Enums;

namespace Tumakov.Classes
{
    class BankAccountChanged : BankAccount
    {
        protected static int increasingNumber = 1;
        protected static int NumberChange()
        {
            return increasingNumber++;
        }
        public BankAccountChanged(decimal balance, TypeBankAccount type) : base(NumberChange(), balance, type) { }
    }
}
