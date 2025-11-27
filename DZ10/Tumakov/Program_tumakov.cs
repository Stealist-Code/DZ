using System;
using Tumakov.Enums;
using Tumakov.Classes;

namespace Tumakov
{
    public delegate int BookComparison(Book book1, Book book2); // делегат, для дз 12.2
    internal class Program_tumakov
    {
        static void Exercise_11_1()
        {
            Bank bank = new Bank();
            var bankAccount = bank.CreateAccount();
            bank.GetAccount(bankAccount).PrintInfoBA();
            bank.CloseAccount(bankAccount);
        }
        
        static void HomeWork_11_1()
        {
            var building1 = Creator.CreateBuild(50.5m, 16, 64, 4);
            Console.WriteLine($"Создано здание с ID: {building1.Id}");

            var building2 = Creator.CreateBuild(999, 30.0m, 10, 40, 2);
            Console.WriteLine($"Создано здание с ID: {building2.Id}");

            Console.WriteLine($"\nКол-во зданий: {Creator.buildings.Count}");

            building1.PrintInfo();

            building2.PrintInfo();

            Console.WriteLine("\nУдаление здания.---");
            Creator.RemoveBuild(building2.Id);
            Console.WriteLine($"Осталось {Creator.buildings.Count} зданий");
        }

        static void Exercise_12_1()
        {
            BankAccountModified bankAccountModified1 = new BankAccountModified();
            var bankAccountModifiedCopy = bankAccountModified1;
            BankAccountModified bankAccountModified2 = null;

            Console.WriteLine(bankAccountModified1.Equals(bankAccountModifiedCopy));
            Console.WriteLine(bankAccountModified1 == bankAccountModified2);
            Console.WriteLine(bankAccountModified1 != bankAccountModifiedCopy);
            Console.WriteLine(bankAccountModified1.GetHashCode());
            Console.WriteLine(bankAccountModified1.ToString());
        }

        static void Exercise_12_2()
        {
            RationalNumbers number1 = new RationalNumbers(11,13);
            RationalNumbers number2 = new RationalNumbers(50, 12);
            RationalNumbers number3 = new RationalNumbers(63, 1);
            RationalNumbers number4 = new RationalNumbers(6, 1);

            Console.WriteLine(number1.ToString());

            number1 -= new RationalNumbers(1, 13);
            Console.WriteLine(number1.ToString());

            number1 += new RationalNumbers(5, 2);
            Console.WriteLine(number1.ToString());

            number1++;
            Console.WriteLine(number1.ToString());

            number1--;
            Console.WriteLine(number1.ToString());

            number3 %= number4;
            Console.WriteLine(number3.ToString());

            number3 *= number4;
            Console.WriteLine(number3.ToString());

            number3 /= number4;
            Console.WriteLine(number3.ToString());

            var number5 = number1;
            Console.WriteLine(number1 < number2);
            Console.WriteLine(number1 > number2);
            Console.WriteLine(number1 <= number3);
            Console.WriteLine(number1 >= number2);
            Console.WriteLine(number1 == number2);
            Console.WriteLine(number1 != number2);
        }

        static void HomeWork_12_1()
        {
            ComplexNumbers number1 = new ComplexNumbers(2, 1);
            ComplexNumbers number2 = new ComplexNumbers(10, -5);

            Console.WriteLine(number1.ToString());
            Console.WriteLine(number2.ToString());

            number1 -= number2;
            Console.WriteLine(number1.ToString());

            number2 += new ComplexNumbers(-5.5, 10.1);
            Console.WriteLine(number2.ToString());

            number1 *= number2;
            Console.WriteLine(number1.ToString());
        }

        static void HomeWork_12_2()
        {
            Book[] books = {
                new Book("Программирование на языке C#", "Тумаков", "КФУ"),
                new Book("Война и мир", "Толстой", "Всемирная литература"),
                new Book("451 градус по фаренгейту", "Рэй Бредбери", "Белые крылья"),
                new Book("Мартин Иден", "Джек Лондон", "Эксмо"),
                new Book("Мы", "Евгений Замятин", "Эксклюзивная классика"),
                new Book("Мастер и Маргарита", "Михаил Булгаков", "Всемирная литература"),
                new Book("Маленький принц", "Антуана", "Эксмо"),
                new Book("","","")
            };
            books[books.Length-1] = null;
            books[1] = null;
            ContainerForBooks container = new ContainerForBooks(books);
            container.PrintBooks();

            Console.WriteLine("\nСортировка по названию ---");
            BookComparison nameSorter = new BookComparison(BookCompareType.CompareName);
            container.SortBooks(nameSorter);
            container.PrintBooks();

            Console.WriteLine("\nСортировка по автору ---");
            BookComparison authorSorter = new BookComparison(BookCompareType.CompareAuthor);
            container.SortBooks(authorSorter);
            container.PrintBooks();

            Console.WriteLine("\nСортировка по издательству ---");
            BookComparison publishingSorter = new BookComparison(BookCompareType.ComparePublishing);
            container.SortBooks(publishingSorter);
            container.PrintBooks();

            Console.WriteLine("\nПроверка на наличие критерия сортировки ---");
            BookComparison nullSorter = new BookComparison(BookCompareType.CompareName);
            nullSorter = null;
            container.SortBooks(nullSorter);
        }
        static void Main(string[] args)
        {
            // Упражнение 11.1
            Console.WriteLine("Упражнение 11.1");
            Exercise_11_1();

            // Упражнение 11.2
            Console.WriteLine("\nУпражнение 11.2\n");

            // Домашняя работа 11.1
            Console.WriteLine("\nДомашняя работа 11.1\n");
            HomeWork_11_1();

            // Упражнение 12.1
            Console.WriteLine("\nУпражнение 12.1\n");
            Exercise_12_1();

            // Упражнение 12.2
            Console.WriteLine("\nУпражнение 12.2\n");
            Exercise_12_2();

            // Упражнение 12.1
            Console.WriteLine("\nДомашняя работа 12.1\n");
            HomeWork_12_1();

            // Упражнение 12.2
            Console.WriteLine("\nДомашняя работа 12.2\n");
            HomeWork_12_2();
        }
    }
}
