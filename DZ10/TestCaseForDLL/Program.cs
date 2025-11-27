using System;
using BankAccountLibrary.Classes;
using BuildingLibrary.Classes;

namespace TestCaseForDLL
{
    internal class Program
    {
        static void Exersice_11_2()
        {
            Bank bank = new Bank();
            var bankAccount1 = bank.CreateAccount();
            bank.GetAccount(bankAccount1).PrintInfoBA();
        }

        static void HomeWork_11_2()
        {
            var building1 = Creator.CreateBuild(50.6m, 16, 39, 3);
            Console.WriteLine($"Создано здание с ID: {building1.Id}");

            var building2 = Creator.CreateBuild(163, 76.0m, 15, 23, 1);
            Console.WriteLine($"Создано здание с ID: {building2.Id}");

            Console.WriteLine($"\nКол-во зданий: {Creator.buildings.Count}");

            building1.PrintInfo();

            building2.PrintInfo();

            Console.WriteLine("\nУдаление здания.---");
            Creator.RemoveBuild(building2.Id);
            Console.WriteLine($"Осталось зданий: {Creator.buildings.Count} шт");
        }
        static void Main(string[] args)
        {
            // Упражнение 11.2
            Console.WriteLine("Упражнение 11.2");
            Exersice_11_2();

            // Домашнее задание 11.2
            Console.WriteLine("\nДомашнее задание 11.2\n");
            HomeWork_11_2();
        }
    }
}
