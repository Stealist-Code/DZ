using System;
using Tumakov.Enums;

namespace Tumakov.Classes
{
    public class BankAccountModified
    {
        public long Number { get; private set; }
        public decimal Balance { get; set; }
        public TypeBankAccount Type { get; protected set; }
        protected static int IncreasingNumber = 1;
        protected static int NumberChange()
        {
            return IncreasingNumber++;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"\n--- Информация о карте. ---\nНомер: {Number}\nБаланс: {Balance}\nТип: {Type}");
        }

        public BankAccountModified(decimal balance, TypeBankAccount type)
        {
            Number = NumberChange();
            Balance = balance >= 0m ? balance : 0m;
            Type = type;
        }
        public BankAccountModified(decimal balance)
        {
            Number = NumberChange();
            Balance = balance >= 0m ? balance : 0m;
            Type = TypeBankAccount.Current; //по умолчанию Current
        }
        public BankAccountModified(TypeBankAccount type)
        {
            Number = NumberChange();
            Balance = 0m;
            Type = type;
        }
        public BankAccountModified()
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
        public static bool operator ==(BankAccountModified account1, BankAccountModified account2)
        {
            if (ReferenceEquals(account1, null))
            {
                return ReferenceEquals(account2, null);
            }
            else if (ReferenceEquals(account2, null))
            {
                return false;
            }
            return account1.Number == account2.Number && account1.Balance == account2.Balance && account1.Type == account2.Type;
        }
        public static bool operator !=(BankAccountModified account1, BankAccountModified account2)
        {
            return !(account1 == account2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            return this == (BankAccountModified)obj;
        }
        public override int GetHashCode()
        {
            unchecked 
            {
                int hash = 17;
                hash = hash * 23 + Number.GetHashCode();
                hash = hash * 23 + Balance.GetHashCode();
                hash = hash * 23 + Type.GetHashCode();
                
                return hash;
            }
        }
        public override string ToString()
        {
            return $"Банковский счет.---\n Номер: {Number}, Баланс: {Balance}, Тип: {Type}"; ;
        }
    }
}
