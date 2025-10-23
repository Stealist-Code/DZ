using System;
using Tumakov.Classes;
using Tumakov.Enums;

namespace Tumakov
{
    internal class Program_tumakov
    {
        static void Exercise_7_1()
        {
            var person1 = new BankAccount(102834, 100m, TypeBankAccount.Saving);
            var person2 = new BankAccount(592852, 35m, TypeBankAccount.Current);

            person1.PrintInfoBA();
            person2.PrintInfoBA();
        }
        static void Exercise_7_2()
        {
            var person1 = new BankAccountChanged(100m, TypeBankAccount.Saving);
            var person2 = new BankAccountChanged(35m, TypeBankAccount.Current);

            person1.PrintInfoBA();
            person2.PrintInfoBA();
        }
        static void Exercise_7_3()
        {
            var person1 = new BankAccountNewMethod(100m, TypeBankAccount.Saving);
            var person2 = new BankAccountNewMethod(35m, TypeBankAccount.Current);

            person1.PrintInfoBA();
            person1.WithdrawFromBA(25m);
            person1.PrintInfoBA();
            person2.PrintInfoBA();
            person2.DepositIntoBA(100m);
            person2.PrintInfoBA();
            person2.WithdrawFromBA(1000m);
        }
        static void HomeWork_7_1()
        {
            var build1 = new Building(50.0m, 10, 100, 2);
            var build2 = new Building(35m, 20, 32, 3);

            build1.PrintInfo();
            var arrayObject = build1.GetInfo();
            Console.WriteLine("-------------");
            Console.WriteLine($"Вывод информация о здании, через получение значений. \nУникальный номер здания: {arrayObject[0]}\nВысота: {arrayObject[1]}\nЭтажность: {arrayObject[2]}\nКол-во квартир: {arrayObject[3]}\nКол-во подъездов: {arrayObject[4]}\nВысота этажа: {arrayObject[5]}\nКвартир в подъезде: {arrayObject[6]}\nКвартир на этаже: {arrayObject[7]}");
        }
        static void Main(string[] args)
        {
            try
            {
                // Упражнение 7.1
                Console.WriteLine("Упражнение 7.1\n");
                Exercise_7_1();

                // Упражнение 7.2
                Console.WriteLine("\nУпражнение 7.2\n");
                Exercise_7_2();

                // Упражнение 7.3
                Console.WriteLine("\nУпражнение 7.3\n");
                Exercise_7_3();

                // ДЗ 7.1
                Console.WriteLine("\nДомашнее задание 7.1\n");
                HomeWork_7_1();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            
        }
    }
}
