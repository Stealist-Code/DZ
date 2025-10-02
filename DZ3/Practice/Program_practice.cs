using System;
using System.Collections.Generic;
using System.Linq;
using static Practice.Enum_Structure.Enum;

namespace Practice
{
    internal class Program_practice
    {

        static void Main(string[] args)
        {

            


            // Упражнение 1
            Console.WriteLine("Упражнение 1\n");

            bool falseCheck = true;
            List<int> listInt = new List<int>();
            Console.WriteLine("Введите числа. Если захотите прервать список, напишите любое слово: ");
            while (int.TryParse(Console.ReadLine(),out int inputInt) == true)
            {
                listInt.Add(inputInt);
            }

            int number = 0;
            for (int i = 1; i < listInt.Count; i++)
            {
                if (listInt[i - 1] >= listInt[i])
                {
                    falseCheck = false;
                    number = i;
                    break;
                }
            }

            if (falseCheck == false)
                {
                    Console.WriteLine($"Последовательность не упорядочена по возрастанию. Нарушает позицию номер: {number+1}");
                }
            else
                {
                    Console.WriteLine("Последовательность упорядочена по возрастанию.");
                }


            // Упражнение 2
            Console.WriteLine("\nУпражнение 2\n");

            string[] nameC = { "Шестерка", "Семерка", "Восьмерка", "Девятка", "Десятка", "Валет", "Дама", "Король", "Туз" };

            Console.Write("Напишите номер карты(от 6 до 14): ");
            if (int.TryParse(Console.ReadLine(), out int k))
            {
                try
                {
                    Console.WriteLine($"Числу {k} соответствует карта - {nameC[k-6]}");
                }
                catch (System.IndexOutOfRangeException)
                {
                    Console.WriteLine("Вы ввели неправильное число. (6 <= k <= 14)");
                }
                finally
                {
                    Console.WriteLine("Конец программы.");
                }

            }

            // Упражнение 3
            Console.WriteLine("\nУпражнение 3\n");

            Dictionary<string, string> inputOutputValues = new Dictionary<string, string>()
            {
                {"jabroni", "Patron Tequila"},
                {"school counselor", "Anything with Alcohol"},
                {"programmer", "Hipster Craft Beer"},
                {"bike gang member", "Moonshine"},
                {"politican", "Your tax dollars"},
                {"rapper", "Cristal"}
            };

            Console.Write("Напишите любое слово из этого списка: Jabroni, School Counselor, Programmer, Bike Gang Member,\n Politican, Rapper, или другое, которого нет в списке: ");
            string inputValues = Console.ReadLine();
            try
            {
                Console.WriteLine(inputOutputValues[inputValues.ToLower()]);
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                Console.WriteLine("Beer");
            }

            // Упражнение 4
            Console.WriteLine("\nУпражнение 4\n");

            int numbDay;
            Console.Write("Напишите порядковый номер дня недели(от 1 до 7): ");
            if (int.TryParse(Console.ReadLine(), out numbDay))
            {
                if (numbDay <= 7)
                {
                    Console.WriteLine((WeekDays)(numbDay - 1));
                }
                else
                {
                    Console.WriteLine("В неделе только 7 дней.");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не число!");
            }


            // Упражнение 5
            Console.WriteLine("\nУпражнение 5\n");

            int bag = 0;
            string[] toy = { "Hello Kitty", "Barbie doll" };
            string[] difSubjects = { "Scissors", "Shoes", "Hello Kitty", "Bottle of water", "Barbie doll", "Hat", "Ball", "Hello Kitty", "Help Kitty", "Hello Kitty" };
            foreach (string subject in difSubjects)
            {
                if (toy.Contains(subject))
                {
                    bag++;
                }
            }
            Console.WriteLine($"В сумке {bag} кукол");

        }
    }
}
