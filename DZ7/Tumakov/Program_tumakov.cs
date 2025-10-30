using System;
using Tumakov.Classes;
using System.IO;
using System.Linq;

namespace Tumakov
{
    internal class Program_tumakov
    {
        static void Exercise_8_1()
        {
            var BAccount1 = new BankAccount(100m, Enums.TypeBankAccount.Current);
            var BAccount2 = new BankAccount(25m, Enums.TypeBankAccount.Saving);
            BAccount1.PrintInfoBA();
            BAccount2.PrintInfoBA();
            BAccount2.MoneyTransfer(BAccount1, 25m);
            BAccount2.PrintInfoBA();
        }
        static void Exercise_8_2(string text)
        {
            Console.WriteLine($"Из строки: {text}, при переворачивании получилась строка: {ReverseString(text)}");
        }
        static string ReverseString(string input)
        {
            string output = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            return output;
        }
        // Другой способ решить задачу. Лучше оптимизирован.
        static string ReverseStringArray(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            return reversed;
        }
        static void Exercise_8_3(string input)
        {
            string fileName = $@"..\..\Files\{input}.txt";
            if (File.Exists(fileName))
            {
                string textFromFile = File.ReadAllText(fileName);
                File.WriteAllText($@"..\..\Files\OutputTextEx-8-3.txt", textFromFile.ToUpper());
                Console.WriteLine($"Данные из файла {input}.txt успешно перенесены в выходной файл OutputTextEx-8-3.txt");
            }
            else
            {
                Console.WriteLine($"Файл {input} не существует");
                Environment.Exit(0);
            }
        }
        static void Exercise_8_4()
        {
            int numb = 154;
            string text = "qwerty";
            object obj = new object();
            IFormattables(numb);
            IFormattables(text);
            IFormattables(obj);
        }
        static bool IFormattables(object input)
        {
            var formattable = input as IFormattable;
            if (formattable is null)
            {
                Console.WriteLine($"{input.GetType()} нереализует IFormattable");
                return false;
            }
            Console.WriteLine($"{input.GetType()} реализует IFormattable");
            return true;
        }

        static void HomeWork_8_1()
        {
            string fileNameInput = $@"..\..\Files\Data-8-1.txt";
            string fileNameOutput = $@"..\..\Files\Email.txt";
            string textFromFile = File.ReadAllText(fileNameInput);
            SearchMail(ref textFromFile);
            File.WriteAllText(fileNameOutput, textFromFile);
            Console.WriteLine("Успешно. Данные в файле Email");
        }
        public static void SearchMail(ref string s)
        {
            var dataArray = s.Replace(" ", "").Split('\n');
            var dataArrayText = new string[dataArray.Length][];
            var emailArray = new string[dataArray.Length];
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArrayText[i] = dataArray[i].Split('#');
                emailArray[i] = dataArrayText[i][1];
            }
            s = string.Join("", emailArray);
        }
        static void HomeWork_8_2()
        {
            var song1 = new Song("Сансара", "Баста");
            var song2 = new Song("Smells Like Teen Spirit", "Nirvana");
            var song3 = new Song("Розовое вино", "Элджей", song1);
            var song4 = new Song("Pride", "Kendrick Lamar", song2);
            var song5 = new Song("Сансара", "Баста");
            var songsArray = new Song[5]{song1, song2, song3, song4, song5};

            Console.WriteLine("--- Информация о песнях ---");
            foreach (var song in songsArray)
            {
                Console.WriteLine(song.Title());
            }
            Console.WriteLine("-- Сравнение ---");
            Console.WriteLine($"Сравнение song1 и song2: {song1.Equals(song2)} ");
            Console.WriteLine($"Сравнение song1 и song3: {song1.Equals(song3)} ");
            Console.WriteLine($"Сравнение song1 и song5: {song1.Equals(song5)} ");
        }
        static void Main(string[] args)
        {
            // Упражнение 8.1
            Console.WriteLine("Упражнение 8.1\n");
            Exercise_8_1();

            // Упражнение 8.2
            Console.WriteLine("\nУпражнение 8.2\n");
            Console.Write("Напишите любой текст:");
            Exercise_8_2(Console.ReadLine());

            // Упражнение 8.3
            Console.WriteLine("\nУпражнение 8.3\n");
            Console.Write("Введите имя файла(существует файл с именем Text): ");
            Exercise_8_3(Console.ReadLine());

            // Упражнение 8.4
            Console.WriteLine("\nУпражнение 8.4\n");
            Exercise_8_4();

            // Домашнее задание 8.1
            Console.WriteLine("\nДомашнее задание 8.1\n");
            HomeWork_8_1();

            // Домашнее задание 8.2
            Console.WriteLine("\nДомашнее задание 8.2\n");
            HomeWork_8_2();
        }
    }
}
