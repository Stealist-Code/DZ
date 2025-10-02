using System;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Упражнение 4.1
            Console.WriteLine("Упражнение 4.1\n");

            Console.Write("Введите кол-во дней: ");
            int quantityDays;

            if (!int.TryParse(Console.ReadLine(), out quantityDays) || quantityDays > 365 || quantityDays < 1)
            {
                Console.WriteLine("Вы ввели неправильные значения");
            }
            else
            {
                int[] mouthInt = { 31, 29, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
                string[] mounthString = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
                int i = 0;
                while (quantityDays > mouthInt[i%12])
                {
                    quantityDays -= mouthInt[i%12];
                    i++;
                }

                Console.WriteLine($"Получилось: {quantityDays} {mounthString[i]}");
            }


            

            // Упражнение 4.2
            Console.WriteLine("\nУпражнение 4.1\n");

            Console.Write("Введите кол-во дней: ");
            bool checkNumber = (!int.TryParse(Console.ReadLine(), out quantityDays) || quantityDays > 365 || quantityDays < 1);
            
            switch (checkNumber)
            {
                case false:
                    int[] mouthInt = { 31, 28, 31, 30, 31, 30, 31, 31, 31, 30, 31, 30 };
                    string[] mounthString = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
                    int i = 0;
                    while (quantityDays > mouthInt[i])
                    {
                        quantityDays -= mouthInt[i];
                        i++;
                    }
              
                    Console.WriteLine($"Получилось: {quantityDays} {mounthString[i]}");
                    break;
                case true:
                    Console.WriteLine("Вы ввели неправильное число.");
                    break;

            }
            
            // Дз-4.1
            Console.WriteLine("\nДомашнее задание 4.1\n");

            int year;
            Console.Write("Введите год: ");
            checkNumber = (!int.TryParse(Console.ReadLine(), out year) || year % 4 == 0 && year % 100 != 0 || year % 400 == 0);

            switch (checkNumber)
            {
                case false:
                    Console.WriteLine($"{year} - обычный год");
                    break;
                case true:
                    Console.WriteLine($"{year} - високосный год");
                    break;


            }
        }
    }
}
