using System;
using System.Threading;
using Tumakov.Classes;

namespace Tumakov
{
    internal class Program_tumakov
    {
        static void Exercise_9_1()
        {
            var BAccount1 = new BankAccount(100m);
            var BAccount2 = new BankAccount(Enums.TypeBankAccount.Saving);
            var BAccount3 = new BankAccount(60m, Enums.TypeBankAccount.Current);
            BAccount1.PrintInfoBA();
            BAccount2.PrintInfoBA();
            BAccount3.PrintInfoBA();
        }

        static void Exercise_9_2()
        {
            var BAccount1 = new BankAccount(175m, Enums.TypeBankAccount.Current);
            var BAccount2 = new BankAccount(Enums.TypeBankAccount.Saving);
            var BAccount3 = new BankAccount(60m, Enums.TypeBankAccount.Current);
            BAccount1.PrintInfoBA();
            BAccount2.PrintInfoBA();
            BAccount3.PrintInfoBA();

            BAccount1.MoneyTransfer(BAccount2, 50m);
            Console.WriteLine("задержка на 5 секунд...");
            Thread.Sleep(5000); // задержка на 5 секунд
            BAccount2.DepositIntoBA(2000m);
            BAccount2.DepositIntoBA(10m);
        }

        static void Exercise_9_3()
        {
            var BAccount1 = new BankAccount(175m, Enums.TypeBankAccount.Current);
            var BAccount2 = new BankAccount(Enums.TypeBankAccount.Saving);
            var BAccount3 = new BankAccount(60m, Enums.TypeBankAccount.Current);
            BAccount1.PrintInfoBA();
            BAccount2.PrintInfoBA();
            BAccount3.PrintInfoBA();

            BAccount1.MoneyTransfer(BAccount2, 50m);
            Thread.Sleep(5000); // задержка на 5 секунд
            BAccount2.DepositIntoBA(2000m);
            BAccount2.DepositIntoBA(10m);
            BAccount2.DepositIntoBA(5m);
            BAccount2.DepositIntoBA(-10m);
            BAccount2.Dispose();

        }

        static void Main(string[] args)
        {
            // Упражнение 9.1
            Console.WriteLine("Упражнение 9.1\n");
            Exercise_9_1();
            // Упражнение 9.2
            Console.WriteLine("\nУпражнение 9.2\n");
            Exercise_9_2();

            // Упражнение 9.3
            Console.WriteLine("\nУпражнение 9.3\n");
            Exercise_9_3();

            // Домашняя работа 9.1
            Console.WriteLine("\nДомашняя работа 9.1\n");

            Song mySong = new Song();
            Console.WriteLine($"{mySong.Name} - это");
        }
    }
}
