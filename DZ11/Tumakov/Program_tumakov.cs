#define DEBUG_ACCOUNT

using System;
using System.Reflection;
using Tumakov.Classes;
using Tumakov.Enums;

namespace Tumakov
{
    internal class Program_tumakov
    {

        static void Exercise_13_1()
        {
            var bankAccount1 = new BankAccount(TypeBankAccount.Saving);
            var bankAccount2 = new BankAccount("Alexey");
            PrintInfoForBankAccount(bankAccount1);
            PrintInfoForBankAccount(bankAccount2);
        }

        static void PrintInfoForBankAccount(BankAccount bankAccount)
        {
            Console.WriteLine($"\nБанковский счет #{bankAccount.Id}");
            Console.WriteLine($"Баланс: {bankAccount.Balance}\nТип: {bankAccount.Type}\nДержатель: {bankAccount.Holder}");
        }

        static void Exercise_13_2()
        {
            var bankAccount1 = new BankAccount(1000m, TypeBankAccount.Saving);
            var bankAccount2 = new BankAccount("Alexey");
            bankAccount1.MoneyTransfer(bankAccount2, 500);
            PrintInfoForBankAccount(bankAccount1);
            bankAccount1.Dispose();
            BankTransaction transaction1 = bankAccount1[0];
            PrintInfoForTransaction(transaction1);

            PrintInfoForBankAccount(bankAccount2);
            BankTransaction transaction2 = bankAccount2[0];
            PrintInfoForTransaction(transaction2);
        }

        static void PrintInfoForTransaction(BankTransaction transaction)
        {
            string changeInAccount = (transaction.ChangesInAccount > 0) ? $"увеличился на {transaction.ChangesInAccount}" : $"уменьшился на {(-1) * transaction.ChangesInAccount}";
            Console.WriteLine($"\nИнформация о транзакции.---\nДата: {transaction.Date}\nИзменения в балансе: {changeInAccount}");
        }

        static void HomeWork_13_1()
        {
            var build1 = new Building(50m, 10, 100, 2);
            var build2 = new Building(35m, 20, 32, 3);
            PrintInfoForBuilding(build1);
            PrintInfoForBuilding(build2);
            build1.NumbFlat = 150;
            build2.Height = 25m;
            PrintInfoForBuilding(build1);
            PrintInfoForBuilding(build2);
        }

        static void PrintInfoForBuilding(Building building)
        {
            Console.WriteLine($"\nИнформация о здании.---\nУникальный номер здания: {building.Id}\nВысота: {building.Height}\nЭтажность: {building.NumbFloors}\nКол-во квартир: {building.NumbFlat}\nКол-во подъездов: {building.NumbEntrance}\nВысота этажа: {building.CalculHeightFloors()}\nКвартир в подъезде: {building.CalculNumbFlatEntrance()}\nКвартир на этаже: {building.CalculateApartmentsPerFloor()}");
        }

        static void HomeWork_13_2()
        {
            var build1 = new Building(50.0m, 10, 100, 2);
            var build2 = new Building(35m, 20, 32, 3);
            var build3 = new Building(20m, 35, 20, 10);
            var build4 = new Building(5m, 12, 40, 4);
            var buildingArray = new Building[] { build1, build2, build3, build4 };
            var buildingArrayForSeveralBuildings = new Building[10];
            var severalBuildings = new SeveralBuildings(buildingArray);
            for (int i=0; i < buildingArray.Length; i++)
            {
                Console.WriteLine(severalBuildings[i]);
                //PrintInfoForBuilding(severalBuildings[i]); // Если нужно вывести
            }
        }

        static void Exercise_14_1()
        {
            var bankAccount1 = new BankAccount(TypeBankAccount.Saving);
            var bankAccount2 = new BankAccount("Alexey");
            PrintInfoForBankAccount(bankAccount1);
            PrintInfoForBankAccount(bankAccount2);

            bankAccount1.DumpToScreen();
        }

        static void Exercise_14_2()
        {
            var bankAccount1 = new BankAccount(TypeBankAccount.Saving);
            var bankAccount2 = new BankAccount("Alexey");
            PrintInfoForBankAccount(bankAccount1);
            PrintInfoForBankAccount(bankAccount2);
        }

        static void FindAttributeExercise_14_2()
        {
            Type type = typeof(RationalNumbers);
            var attributes = type.GetCustomAttributes<DeveloperInfoAttribute>();
            foreach (var attribute in attributes)
            {
                attribute.Print();
            }
        }

        static void FindAttributeHomeWork_14_1()
        {
            Type type = typeof(Building);
            var attribute = type.GetCustomAttribute<DeveloperInfoForBuildingAttribute>();
            if (attribute != null)
            {
                attribute.Print();
            }
            else
            {
                Console.WriteLine("Атрибут не найден.");
            }
        }

        static void Main(string[] args)
        {
            // Упражнение 13.1
            Console.WriteLine("Упражнение 13.1\n");
            Exercise_13_1();

            // Упражнение 13.2
            Console.WriteLine("\nУпражнение 13.2\n");
            Exercise_13_2();

            // Домашнее задание 13.1
            Console.WriteLine("\nДомашнее задание 13.1\n");
            HomeWork_13_1();

            // Домашнее задание 13.2
            Console.WriteLine("\nДомашнее задание 13.2\n");
            HomeWork_13_2();

            // Упражнение 14.1
            Console.WriteLine("\nУпражнение 14.1\n");
            Exercise_14_1();

            // Упражнение 14.2
            Console.WriteLine("\nУпражнение 14.2");
            FindAttributeExercise_14_2();

            // Домашнее задание 14.1
            Console.WriteLine("\nДомашнее задание 14.1\n");
            FindAttributeHomeWork_14_1();
        }
    }
}
