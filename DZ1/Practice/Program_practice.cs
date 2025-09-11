using System;
using System.Threading;

namespace Practice
{
    internal class Program_practice
    {
        static void Main(string[] args)
        {
            // Упражнение 1
            Console.WriteLine("Упражнение 1\n");

            string numberE = ((float)(Math.E)).ToString();
            string numberE2 = numberE.Substring(0,3);
            Console.WriteLine(numberE2);

            // Упражнение 2
            Console.WriteLine("\nУпражнение 2\n");

            Console.WriteLine("50");
            Console.WriteLine("10");

            // Упражнение 3
            Console.WriteLine("\nУпражнение 3\n");

            Random r = new Random();

            for (int i = 0; i < 4; i++)
                Console.WriteLine(r.Next(100));

            // Упражнение 4
            Console.WriteLine("\nУпражнение 4\n");

            Console.Write("Введите число: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(input+10);

            // Упражнение 5
            Console.WriteLine("\nУпражнение 5\n");

            Console.Write("Введите угол(для cos(x)): ");
            int ugol = int.Parse(Console.ReadLine());

            if ((ugol / 90) % 2 == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                double x = Math.PI * ugol / 180;
                Console.WriteLine(Math.Cos(x));
            }

            // Упражнение 6
            Console.WriteLine("\nУпражнение 6\n");

            Console.Write("Введите большее основание: ");
            int osnovBig = int.Parse(Console.ReadLine());

            Console.Write("Введите меньшее основание: ");
            int osnovSmall = int.Parse(Console.ReadLine());

            Console.Write("Введите высоту: ");
            int height = int.Parse(Console.ReadLine());

            float katet = (float)(osnovBig - osnovSmall) / 2;

            float gipotenuza = (float)(Math.Sqrt((float)(Math.Pow(height, 2) + Math.Pow(katet, 2))));

            float perimetr = osnovSmall + osnovBig + gipotenuza * 2;

            Console.WriteLine(perimetr);

            // Упражнение 7
            Console.WriteLine("\nУпражнение 7\n");

            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("\tТруд");
            Console.WriteLine("\t\tМай");

            // Упражнение 8
            Console.WriteLine("\nУпражнение 8\n");

            Console.Write("Введите первую числовую переменную: ");
            int p1 = int.Parse(Console.ReadLine());

            Console.Write("Введите вторую числовую переменную: ");
            int p2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{p2}, {p1}");

            // Упражнение 9
            Console.WriteLine("\nУпражнение 9\n");

            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Вы ввели число {number}");

            

            // Упражнение 10
            Console.WriteLine("\nУпражнение 10\n");

            Console.Write("Уравнение вида ax^2 + bx + c\na = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            int discriminant = (int)(Math.Pow(b, 2) - 4 * a * c);
            if (discriminant < 0) Console.WriteLine("Нет корней");
            else
            {
                int xOne = (int)(-1 * b + Math.Sqrt(discriminant)) / 2;
                int xTwo = (int)(-1 * b - Math.Sqrt(discriminant)) / 2;
                Console.WriteLine($"Первый корень: {xOne}\nВторой корень: {xTwo}");
            }

            // Упражнение 11
            Console.WriteLine("\nУпражнение 11\n");

            Console.Write("Введите первое число: ");
            int numberOne = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int numberTwo = int.Parse(Console.ReadLine());

            double srArifmet = (double)(numberOne + numberTwo) / 2;
            double srGeom = Math.Sqrt(numberOne * numberTwo);

            Console.WriteLine($"Среднее арифметическое: {srArifmet}\nСреднее геометрическое: {srGeom}");

            // Упражнение 12
            Console.WriteLine("\nУпражнение 12\n");

            Console.Write("Введите координату X первой точки: ");
            int x1 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату Y первой точки: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату X второй точки: ");
            int x2 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату Y второй точки: ");
            int y2 = int.Parse(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2, 2));
            Console.WriteLine($"Расстояние между точками равна: {distance}");

            // Упражнение 13
            Console.WriteLine("\nУпражнение 13\n");

            Console.Write("Переменная A: ");
            int pA = int.Parse(Console.ReadLine());

            Console.Write("Переменная B: ");
            int pB = int.Parse(Console.ReadLine());

            Console.Write("Переменная C: ");
            int pC = int.Parse(Console.ReadLine());

            int dA, dB, dC;
            (dA, dB, dC) = (pA, pB, pC);

            //Пункт а)
            (pA, pB, pC) = (pB, pC, pA);
            Console.WriteLine($"Пункт а) A: {pA}, B: {pB}, C: {pC}");

            //Пункт б)
            (pA, pB, pC) = (dA, dB, dC);
            (pA, pB, pC) = (pC, pA, pB);
            Console.WriteLine($"Пункт б) A: {pA}, B: {pB}, C: {pC}");

            // Упражнение 14
            Console.WriteLine("\nУпражнение 14\n");

            Console.Write("Введите кол-во секунд: ");
            int sec = int.Parse(Console.ReadLine());

            int hourA = sec / 3600;
            Console.WriteLine($"Пункт a): {hourA}");

            int minB = (sec - hourA * 3600) / 60;
            Console.WriteLine($"Пункт б): {minB}");

            int secC = sec - (sec / 60) * 60;
            Console.WriteLine($"Пункт с): {secC}");

            // Упражнение 15
            Console.WriteLine("\nУпражнение 15\n");

            int weight = 543;
            Console.WriteLine(weight/130);

            // Упражнение 16
            Console.WriteLine("\nУпражнение 16\n");

            Console.Write("Введите трехзначное число: ");
            string number3x = Console.ReadLine();
            if (number3x.Length == 3)
            {
                Console.WriteLine(number3x.Substring(2) + number3x.Substring(0, 2));
            }
            else
            {
                Console.WriteLine("Вы ввели не трехзначное число");
            }

            // Упражнение 17
            Console.WriteLine("\nУпражнение 17\n");

            Console.Write("Введите число n, которое превышает 999: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Пункт а): {n/100}");
            Console.WriteLine($"Пункт б): {n / 1000}");

            // Упражнение 18
            Console.WriteLine("\nУпражнение 18\n");

            Console.WriteLine("Напиши свое имя: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Пункт а): {name}");
            Console.WriteLine($"Пункт б): Рад тебя видеть, {name}!");

            // Упражнение 19
            Console.WriteLine("\nУпражнение 19\n");

            Console.WriteLine("Дневник Тома Реддла");
            string hi = Console.ReadLine();
            Console.WriteLine("Дневник: Как тебя зовут?");
            Console.Write("Гарри: ");
            string nameUser = Console.ReadLine();
            Console.WriteLine($"Дневник: Привет, {nameUser}");
            Console.Write("Гарри (спроси о тайной комнате): ");
            Console.ReadLine();
            Console.WriteLine("Дневник: Да");
            Console.Write("Гарри (спроси, может ли он рассказать о ней): ");
            Console.ReadLine();
            Console.WriteLine("Дневник: Нет");
            Thread.Sleep(5000);
            Console.WriteLine("Дневник: Но могу показать");

            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.BackgroundColor = colors[new Random().Next(0, colors.Length - 1)];
            Console.Clear();

            // Упражнение 20
            Console.WriteLine("\nУпражнение 20\n");

            string num = Console.ReadLine();

            int chet = 0;
            int nechet = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (i % 2 == 0)
                {
                    chet += int.Parse(num[i].ToString());
                }
                else
                {
                    nechet += int.Parse(num[i].ToString());
                }
            }

            nechet *= 3;
            int sum = chet + nechet;
            if (sum % 10 != 0)
            {
                num += Convert.ToString(10 - sum % 10);
            }
            else
            {
                num += 0;
            }

            Console.WriteLine(num);


            Console.ReadKey();
        }
    }
}
