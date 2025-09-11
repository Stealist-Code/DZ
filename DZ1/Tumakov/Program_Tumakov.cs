using System;

namespace Tumakov
{
    internal class Program_Tumakov
    {
        static void Main(string[] args)
        {
            // Упражнение 2.1
            Console.WriteLine("Упражнение 2.1\n");
            Console.WriteLine("Привет. Как тебя зовут?");

            Console.Write("Напиши свое имя: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Рад тебя видеть, {name}!");

            Console.ReadKey();

            // Упражнение 2.2
            Console.WriteLine("\n\nУпражнение 2.2\n");
            try
            {
                Console.Write("Введите первое число(делимое): ");
                int number1 = int.Parse(Console.ReadLine());

                Console.Write("Введите второе число(делитель): ");
                int number2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Результат от деления(частное): {number1 / number2}");
            }catch(DivideByZeroException) {
                Console.WriteLine("На ноль делить нельзя!");
            }catch(FormatException){
                Console.WriteLine("Вы ввели не тот формат!");
            }

            // Дз-1
            Console.WriteLine("\n\nДз-1\n");

            Console.Write("Напишите любую букву из алфавита: ");
            char letter = char.Parse(Console.ReadLine());
            char nextLetter;

            if (letter == 'z')
                nextLetter = 'a';
            else if (letter == 'Z')
                nextLetter = 'A';
            else
                nextLetter = (char)(((int)letter) + 1);
         
            Console.WriteLine(nextLetter);

            // Дз-2
            Console.WriteLine("\n\nДз-2\n");

            Console.Write("Уравнение вида ax^2 + bx + c\na = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            int discriminant = (int)(Math.Pow(b,2) - 4*a*c);
            if (discriminant < 0) Console.WriteLine("Нет корней");
            else
            {
                int x1 = (int)(-1 * b + Math.Sqrt(discriminant)) / 2;
                int x2 = (int)(-1 * b - Math.Sqrt(discriminant)) / 2;
                Console.WriteLine($"Первый корень: {x1}\nВторой корень: {x2}");
            }

        }
        
    }
}
