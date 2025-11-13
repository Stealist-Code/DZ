using System;

namespace Tumakov.Classes
{
    class BankTransaction
    {
        public readonly DateTime Date;
        public readonly decimal ChangesInAccount;

        public BankTransaction(decimal changesInAccount)
        {
            Date = DateTime.Now;
            ChangesInAccount = changesInAccount;
        }
    }
}
