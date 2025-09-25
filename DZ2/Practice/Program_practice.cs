using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static Practice.struct_enum;

namespace Practice
{
    internal class Program_practice
    {
        
        static void Main(string[] args)
        {


            // Упражнение 1
            Console.WriteLine("Упражнение 1\n");

            Console.WriteLine($"sbyte – {sbyte.MaxValue} – {sbyte.MinValue}");
            Console.WriteLine($"byte – {byte.MaxValue} – {byte.MinValue}");
            Console.WriteLine($"short – {short.MaxValue} – {short.MinValue}");
            Console.WriteLine($"ushort – {ushort.MaxValue} – {ushort.MinValue}");
            Console.WriteLine($"int – {int.MaxValue} – {int.MinValue}");
            Console.WriteLine($"uint – {uint.MaxValue} – {uint.MinValue}");
            Console.WriteLine($"long – {long.MaxValue} – {long.MinValue}");
            Console.WriteLine($"ulong – {ulong.MaxValue} – {ulong.MinValue}");
            Console.WriteLine($"float – {float.MaxValue} – {float.MinValue}");
            Console.WriteLine($"double – {double.MaxValue} – {double.MinValue}");
            Console.WriteLine($"decimal – {decimal.MaxValue} – {decimal.MinValue}");

            // Упражнение 2
            Console.WriteLine("\nУпражнение 2\n");

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите город: ");
            string city = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Введите PIN-код: ");
            string pin = Console.ReadLine();

            Console.WriteLine("\nИнформация о пользователе:");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Город: {city}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"PIN-код: {pin}");

            // Упражнение 3
            Console.WriteLine("\nУпражнение 3\n");

            Console.Write("Напишите любое слово на английском: ");
            string input = Console.ReadLine();
            string output = "";
            Console.WriteLine(input[1]);
            for (int i = 0; i != input.Length; i++)
            {
                if ((int)input[i] > 90)
                {
                    output += (char)((int)input[i] - 32);
                }
                else
                {
                    output += (char)((int)input[i] + 32);
                }


            }
            Console.WriteLine($"Получившаяся строка: {output}");

            // Упражнение 4
            Console.WriteLine("\nУпражнение 4\n");

            Console.Write("Напишите строку: ");
            string str = Console.ReadLine();
            Console.Write("Напишите подстроку: ");
            string podstr = Console.ReadLine();
            int n;
            if (str.Contains(podstr))
            {
                n = (str.Length - str.Replace(podstr, "").Length) / podstr.Length;
            }
            else
            {
                n = 0;
            }
            Console.WriteLine($"{n} раз подстрока встречается в строке");

            // Упражнение 5
            Console.WriteLine("\nУпражнение 5\n");

            Console.Write("Введите обычную цену: ");
            float normPrice = int.Parse(Console.ReadLine());
            Console.Write("Введите размер скидки: ");
            float salePrice = int.Parse(Console.ReadLine());
            Console.Write("Введите цену на отпуск: ");
            float holidayPrice = int.Parse(Console.ReadLine());
            float notnormPrice = normPrice * salePrice / 100;
            int count;
            if (holidayPrice % notnormPrice == 0)
            {
                count = (int)(holidayPrice / notnormPrice);
            }
            else
            {
                count = (int)(holidayPrice / notnormPrice + 1);
            }

            Console.WriteLine($"Нужно купить {count} шт, что бы пойти в отпуске");

            // Упражнение 6
            Console.WriteLine("\nУпражнение 6\n");

            lemonade lm;
            lm.type = (categoryBewerage)0;
            lm.alcohol = 0;

            beer br;
            br.type = (categoryBewerage)1;
            br.alcohol = 5;

            wine wn;
            wn.type = (categoryBewerage)1;
            wn.alcohol = 16;


            Students p1;
            p1.surname = "Иванов";
            p1.name = "Иван";
            p1.id = 1;
            p1.dateBirth = "21.05.2000";
            p1.categAlcohol = "c";
            p1.volume = 50;

            Students p2;
            p2.surname = "Ковалев";
            p2.name = "Игорь";
            p2.id = 2;
            p2.dateBirth = "11.05.2000";
            p2.categAlcohol = "b";
            p2.volume = 7;

            Students p3;
            p3.surname = "Михайлов";
            p3.name = "Алексей";
            p3.id = 3;
            p3.dateBirth = "20.05.2000";
            p3.categAlcohol = "b";
            p3.volume = 5;

            Students p4;
            p4.surname = "Цзю";
            p4.name = "Саша";
            p4.id = 4;
            p4.dateBirth = "15.05.2000";
            p4.categAlcohol = "a";
            p4.volume = 20;

            Students p5;
            p5.surname = "Крещенко";
            p5.name = "Абдулла";
            p5.id = 5;
            p5.dateBirth = "21.12.2000";
            p5.categAlcohol = "d";
            p5.volume = 10;

            float totalVolume = p1.volume + p2.volume + p3.volume + p4.volume + p5.volume;
            float totalAlcohol = 0;

            if (p1.categAlcohol == "a") { totalAlcohol += p1.volume * wn.alcohol / 100; }
            else if (p1.categAlcohol == "b") { totalAlcohol += p1.volume * br.alcohol / 100; }
            else if (p1.categAlcohol == "c") { totalAlcohol += p1.volume * br.alcohol / 100; }
            else { totalAlcohol += p1.volume * lm.alcohol; }

            if (p2.categAlcohol == "a") { totalAlcohol += p2.volume * wn.alcohol / 100; }
            else if (p2.categAlcohol == "b") { totalAlcohol += p2.volume * br.alcohol / 100; }
            else if (p2.categAlcohol == "c") { totalAlcohol += p2.volume * br.alcohol / 100; }
            else { totalAlcohol += p2.volume * lm.alcohol; }

            if (p3.categAlcohol == "a") { totalAlcohol += p3.volume * wn.alcohol / 100; }
            else if (p3.categAlcohol == "b") { totalAlcohol += p3.volume * br.alcohol / 100; }
            else if (p3.categAlcohol == "c") { totalAlcohol += p3.volume * br.alcohol / 100; }
            else { totalAlcohol += p3.volume * lm.alcohol; }

            if (p4.categAlcohol == "a") { totalAlcohol += p4.volume * wn.alcohol / 100; }
            else if (p4.categAlcohol == "b") { totalAlcohol += p4.volume * br.alcohol / 100; }
            else if (p4.categAlcohol == "c") { totalAlcohol += p4.volume * br.alcohol / 100; }
            else { totalAlcohol += p4.volume * lm.alcohol; }

            if (p5.categAlcohol == "a") { totalAlcohol += p5.volume * wn.alcohol / 100; }
            else if (p5.categAlcohol == "b") { totalAlcohol += p5.volume * br.alcohol / 100; }
            else if (p5.categAlcohol == "c") { totalAlcohol += p5.volume * br.alcohol / 100; }
            else { totalAlcohol += p5.volume * lm.alcohol; }

            Console.WriteLine($"объем алкоголя, который выпили студенты {totalAlcohol}\n");
            Console.WriteLine(p1.categAlcohol);

            if (p1.categAlcohol == "a") { Console.WriteLine($"{p1.name} выпил {(p1.volume * wn.alcohol) / totalAlcohol} процентов алкоголя"); }
            else if (p1.categAlcohol == "b") { Console.WriteLine($"{p1.name} выпил {(p1.volume * br.alcohol) / totalAlcohol} процентов алкоголя"); }
            else if (p1.categAlcohol == "c") { Console.WriteLine($"{p1.name} выпил {p1.volume * br.alcohol / totalAlcohol} процентов алкоголя"); }
            else { Console.WriteLine($"{p1.name} пил лимонад"); }
            Console.WriteLine($"{p1.name} выпил {p1.volume * 100 / totalVolume} процентов от всего объема");

            if (p2.categAlcohol == "a") { Console.WriteLine($"{p2.name} выпил {(p2.volume * wn.alcohol / totalAlcohol)} процентов алкоголя"); }
            else if (p2.categAlcohol == "b") { Console.WriteLine($"{p2.name} выпил {(p2.volume * br.alcohol / totalAlcohol)} процентов алкоголя"); }
            else if (p2.categAlcohol == "c") { Console.WriteLine($"{p2.name} выпил {(p2.volume * br.alcohol / totalAlcohol)} процентов алкоголя"); }
            else { Console.WriteLine($"{p2.name} пил лимонад"); }
            Console.WriteLine($"{p2.name} выпил {p2.volume * 100 / totalVolume} процентов от всего объема");

            if (p3.categAlcohol == "a") { Console.WriteLine($"{p3.name} выпил {(p3.volume * wn.alcohol / totalAlcohol)} процентов алкоголя"); }
            else if (p3.categAlcohol == "b") { Console.WriteLine($"{p3.name} выпил {(p3.volume * br.alcohol / totalAlcohol)} процентов алкоголя"); }
            else if (p3.categAlcohol == "c") { Console.WriteLine($"{p3.name} выпил {(p3.volume * br.alcohol / totalAlcohol)} процентов алкоголя"); }
            else { Console.WriteLine($"{p3.name} пил лимонад"); }
            Console.WriteLine($"{p3.name} выпил {p3.volume * 100 / totalVolume} процентов от всего объема");

            if (p4.categAlcohol == "a") { Console.WriteLine($"{p4.name} выпил {(p4.volume * wn.alcohol / totalAlcohol)} процентов алкоголя"); }
            else if (p4.categAlcohol == "b") { Console.WriteLine($"{p4.name} выпил {(p4.volume * br.alcohol / totalAlcohol)} процентов алкоголя"); }
            else if (p4.categAlcohol == "c") { Console.WriteLine($"{p4.name} выпил {(p4.volume * br.alcohol / totalAlcohol)} процентов алкоголя"); }
            else { Console.WriteLine($"{p4.name} пил лимонад"); }
            Console.WriteLine($"{p4.name} выпил {p4.volume * 100 / totalVolume} процентов от всего объема");


            if (p5.categAlcohol == "a") { Console.WriteLine($"{p5.name} выпил {(p5.volume * wn.alcohol / totalAlcohol)} процентов алкоголя"); }
            else if (p5.categAlcohol == "b") { Console.WriteLine($"{p5.name} выпил {(p5.volume * br.alcohol / totalAlcohol)} процентов алкоголя"); }
            else if (p5.categAlcohol == "c") { Console.WriteLine($"{p5.name} выпил {(p5.volume * br.alcohol / totalAlcohol)} процентов алкоголя"); }
            else { Console.WriteLine($"{p5.name} пил лимонад"); }
            Console.WriteLine($"{p5.name} выпил {p5.volume * 100 / totalVolume} процентов от всего объема");
        }
    }
}
