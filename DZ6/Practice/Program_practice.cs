using Practice.Classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace Practice
{
    internal class Program_practice
    {
        static void ExercisePrint()
        {
            Console.WriteLine("--- Загрузка данных из файла. ---");

            string filePath = @"..\..\Files\wastes.txt";
            if (!File.Exists(filePath))
            {
                File.WriteAllLines(filePath, new string[] { "Яблоко;5;false;30;40", "Пластик;2;true;20;Пластик" });
            }

            var lines = File.ReadAllLines(filePath);
            var wastesFromFile = new List<Waste>();
            foreach (var line in lines)
            {
                AddWastesList(line, wastesFromFile);
            }
            Dump dump = new Dump("Городская свалка", 100.0);

            foreach (var waste in wastesFromFile)
            {
                dump.AddWaste(waste);
            }
            OrganicWaste bananaPeel = new OrganicWaste("Банановая кожура", 0.5, false, 3, 14);
            InorganicWaste glassBottle = new InorganicWaste("Стеклянная бутылка", 1.0, false, 2, "стекло");

            dump.AddWaste(bananaPeel);
            dump.AddWaste(glassBottle);

            Console.WriteLine($"\n--- Добро пожаловать в свалку: {dump.Location}! ---\n");

            int number = 1;

            while (number != 0)
            {
                Console.WriteLine("--- Выберите один из пунктов ---");
                Console.WriteLine("1 - Показать все отходы");
                Console.WriteLine("2 - Утилизация отходов");
                Console.WriteLine("3 - Переработка");
                Console.WriteLine("4 - Разложение");
                Console.WriteLine("5 - Общее воздействие");
                Console.WriteLine("6 - Оптимизация свалки");
                Console.WriteLine("7 - Удаление отхода");
                Console.WriteLine("8 - Добавление отхода");
                Console.WriteLine("0 - Завершить программу");
                Console.Write("Введите: ");
                number = IntConvert(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("\n--- Отходы ---");
                        dump.ShowAllWastes();
                        continue;
                    case 2:
                        Console.WriteLine("\n--- Утилизация отходов ---");
                        foreach (var waste in dump.Wastes)
                        {
                            waste.Disponse();
                        }
                        continue;
                    case 3:
                        Console.WriteLine("\n--- Переработка ---");
                        foreach (var waste in dump.Wastes)
                        {
                            waste.Recycle();
                        }
                        continue;
                    case 4:
                        Console.WriteLine("\n--- Разложение ---");
                        foreach (var waste in dump.Wastes)
                        {
                            waste.Decomposition();
                        }
                        continue;
                    case 5:
                        Console.WriteLine("\n--- Общее воздействие ---");
                        dump.CalculateTotalImpact();
                        continue;
                    case 6:
                        Console.WriteLine("\n--- Оптимизация свалки ---");
                        dump.OptimizeDump();
                        dump.ShowAllWastes();
                        continue;
                    case 7:
                        Console.WriteLine("\n--- Удаление отхода ---");
                        Console.Write("Введите название отхода: ");
                        dump.RemoveWaste(Console.ReadLine());
                        dump.ShowAllWastes();
                        continue;
                    case 8:
                        Console.WriteLine("\n--- Добавление отхода ---");
                        Console.WriteLine("Введите данные в формате: название; вес; вред(false или true); объем; время разложения(organic) или материал(inorganic):");
                        string input = Console.ReadLine();
                        if (AddWastesList(input, wastesFromFile))
                        {
                            foreach (var waste in wastesFromFile)
                            {
                                dump.AddWaste(waste);
                            }
                            Console.WriteLine("Успешно!");
                        }
                        continue;
                }
            }

            // Демонстрация свойств
            Console.WriteLine($"\nТекущая загрузка свалки: {dump.CurrentLoad} м^3");
            dump.Location = "Свалка в поле"; // Изменение свойства
            Console.WriteLine($"Новое местоположение: {dump.Location}");
        }

        static double DoubleConvert(string input)
        {
            if (double.TryParse(input, out double output))
            {
                return output;
            }
            else
            {
                throw new Exception("Ошибка во входящих данных");
            }
        }
        static bool BoolConvert(string input)
        {
            if (bool.TryParse(input, out bool output))
            {
                return output;
            }
            else
            {
                throw new Exception("Ошибка во входящих данных");
            }
        }
        static int IntConvert(string input)
        {
            if (int.TryParse(input, out int output))
            {
                return output;
            }
            else
            {
                throw new Exception("Ошибка во входящих данных");
            }
        }
        static bool AddWastesList(string line, List<Waste> wastesFromFile)
        {
            bool result = false;
            var parts = line.Replace(" ", "").Split(';');

            if (parts.Length == 5)
            {
                string name = parts[0];
                double weight = DoubleConvert(parts[1]);
                bool isHarm = BoolConvert(parts[2]);
                int volume = IntConvert(parts[3]);
                if (int.TryParse(parts[4], out int decompositionTime))
                {
                    wastesFromFile.Add(new OrganicWaste(name, weight, isHarm, volume, decompositionTime));
                    result = true;
                }
                else
                {
                    wastesFromFile.Add(new InorganicWaste(name, weight, isHarm, volume, parts[4]));
                    result = true;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            ExercisePrint();
            Console.ReadKey();
        }
    }
}

