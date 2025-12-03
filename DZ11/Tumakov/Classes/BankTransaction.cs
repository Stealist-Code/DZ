using System;

namespace Tumakov.Classes
{
    class BankTransaction
    {
        public DateTime Date { get; private set; }
        public decimal ChangesInAccount { get; private set; }

        public BankTransaction(decimal changesInAccount)
        {
            Date = DateTime.Now;
            ChangesInAccount = changesInAccount;
        }
    }
}