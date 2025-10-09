using System;
using System.Threading;
using static Practice.Enum_Struct.Struct;
using static Practice.Enum_Struct.Enum;

namespace Practice
{
    internal class Program_practice
    {
        static int MethodArray(ref long composition, out double arrifMean, params int[] intArray)
        {
            int sum = 0;
            composition = 1;
            for (int i = 0; i < intArray.Length; i++)
            {
                sum += intArray[i];
                composition *= intArray[i];
            }
            arrifMean = (double)sum / intArray.Length;
            return sum;

        }

        static void DrawingNumd(int numb)
        {
            switch (numb)
            {
                case 0:
                    Console.WriteLine(" #### \n#    #\n#    #\n#    #\n #### ");
                    break;

                case 1:
                    Console.WriteLine("   #  \n  ##  \n # #  \n   #  \n #####");
                    break;

                case 2:
                    Console.WriteLine(" #### \n     #\n #### \n#     \n #### ");
                    break;

                case 3:
                    Console.WriteLine(" #### \n     #\n #### \n     #\n #### ");
                    break;

                case 4:
                    Console.WriteLine("#    #\n#    #\n #####\n     #\n     #");
                    break;

                case 5:
                    Console.WriteLine(" #### \n#     \n #### \n     #\n #### ");
                    break;

                case 6:
                    Console.WriteLine(" #### \n#     \n##### \n#    #\n #### ");
                    break;

                case 7:
                    Console.WriteLine(" #####\n     #\n    # \n   #  \n   #  ");
                    break;

                case 8:
                    Console.WriteLine(" #### \n#    #\n #### \n#    #\n #### ");
                    break;

                case 9:
                    Console.WriteLine(" #### \n#    #\n #####\n     #\n #### ");
                    break;
            }
        }


        static void Main(string[] args)
        {
            



            //Упражнение 1
            Console.WriteLine("Упражнение 1\n");

            int[] intArrayRandom = new int[20];
            Random random = new Random();

            for (int i = 0; i < intArrayRandom.Length; i++)
            {
                intArrayRandom[i] = random.Next(1,501);
            }

            Console.WriteLine($"Массив с 20-ю случайными числами: {string.Join(", ", intArrayRandom)}");

            int indexNumFirst = 0;
            Console.Write("Введите число из данного массива: ");
            if (int.TryParse(Console.ReadLine(), out int numArrayFirst))
            {
                indexNumFirst = Array.IndexOf(intArrayRandom, numArrayFirst);
            }
            int indexNumSecond = 0;
            Console.Write("Введите число из данного массива: ");
            if (int.TryParse(Console.ReadLine(), out int numArraySecond))
            {
                indexNumSecond = Array.IndexOf(intArrayRandom, numArraySecond);
            }

            int temporary = intArrayRandom[indexNumSecond];
            intArrayRandom[indexNumSecond] = intArrayRandom[indexNumFirst];
            intArrayRandom[indexNumFirst] = temporary;

            Console.WriteLine($"Массив в котором поменялись места двух чисел ({numArrayFirst} и {numArraySecond}): {string.Join(", ", intArrayRandom)}");

            //Упражнение 2
            Console.WriteLine("\nУпражнение 2\n");

            int[] intArray = { 1, 2, 3, 4, 5, 6, 775, 8, 128 };
            long composition = 1;
            double arrifMean = 0;

            int sum = MethodArray(ref composition, out arrifMean, intArray);
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {composition}");
            Console.WriteLine($"Среднее арифметическое: {arrifMean}");

            //Упражнение 3
            Console.WriteLine("\nУпражнение 3\n");

            while (true)
            {
                Console.Write("Введите число: ");
                string inputString = Console.ReadLine();
                if (int.TryParse(inputString, out int numb))
                {
                    if (numb >= 0 && numb <= 9)
                    {
                        DrawingNumd(numb);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine("ERROR");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                        Console.Clear();

                    }
                }
                else if (inputString == "exit" || inputString == "закрыть")
                {
                    break;
                }
                else
                {
                    throw new Exception("Нужно ввести число!");
                }

            }

            //Упражнение 4
            Console.WriteLine("\nУпражнение 4\n");

            string[] ded1Array = { "ёлки-палки", "гады", "японский городовой", "ёкарный бабай" };
            string[] ded2Array = { "твою ж медь", "ёшкин кот", "петухи", "чёрт побери" };
            string[] ded3Array = { "проститутки", "ёмоё", "святые угодники", "твою дивизию" };
            string[] ded4Array = { "ёксель-моксель", "проститутки", "твою мать", "петухи" };
            string[] ded5Array = { "проклятие", "святая простота", "твою ты душу", "ёперный театр" };

            Ded ded1 = new Ded("Борис", Grumpiness.none_grumpy, ded1Array);
            Ded ded2 = new Ded("Геннадий", Grumpiness.grumpy, ded2Array);
            Ded ded3 = new Ded("Семён", Grumpiness.grumpy, ded3Array);
            Ded ded4 = new Ded("Аркадий", Grumpiness.very_grumpy, ded4Array);
            Ded ded5 = new Ded("Василий", Grumpiness.none_grumpy, ded5Array);

            string[] swearingArray = { "твою мать", "проститутки", "гады", "петухи", "твою мать" };
            Ded[] deds = { ded1, ded2, ded3, ded4, ded5 };
            foreach (Ded ded in deds)
            {
                Console.WriteLine($"Дед {ded.name} заработал {Ded.Kick(ded, swearingArray)} синяков");
            }


        }
    }
}
