using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Schema;

namespace Tumakov
{
    internal class Program_tumakov
    {
        static void Largest(long numb1, long numb2)
        {
            if (numb2 >= numb1)
            {
                Console.WriteLine(numb2);
            }
            else
            {
                Console.WriteLine(numb1);
            }
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static bool Factorial(int nFact, out long result)
        {
            result = 1;

            try
            {
                checked
                {
                    for (int i = 2; i <= nFact; i++)
                    {
                        result *= i;
                    }
                    
                }
                return true;
            }
            catch (OverflowException)
            {
                result = 0;
                return false;
            }
        }


        static long FactorialRekurs(int numFact)
        {

            if (numFact == 0 || numFact == 1)
            {
                return 1;
            }
            return numFact * FactorialRekurs(numFact-1);
        }

        static int NodCalcul(int numNod1, int numNod2)
        {
            if (numNod1 <= 0 || numNod2 <= 0)
            {
                throw new ArgumentException("Не натуральные числа.");
            }
            
            while (numNod1 != numNod2)
            {
                if (numNod1 > numNod2)
                {
                    numNod1 -= numNod2;
                }
                else
                {
                    numNod2 -= numNod1;
                }
            }
            return numNod1;
        }

        static int NodCalcul(int numNod1, int numNod2, int numNod3)
        {
            return NodCalcul(NodCalcul(numNod1, numNod2), numNod3);
            
        }

        static long Fibonachi(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("n должен быть >0.");
            }

            if (n == 1 || n == 2)
            {
                return 1;
            }

            return Fibonachi(n - 1) + Fibonachi(n-2);
        }

        static void Main(string[] args)
        {

            // Упражнение 5.1
            Console.WriteLine("Упражнение 5.1\n");

            Console.WriteLine("Введите 2 числа в столбик: ");
            if (int.TryParse(Console.ReadLine(), out int k1) & int.TryParse(Console.ReadLine(), out int k2))
            {
                Largest(k1,k2);
            }

            // Упражнение 5.2
            Console.WriteLine("\nУпражнение 5.2\n");

            int int1 = 12;
            int int2 = 53;

            Swap(ref int1, ref int2);
            Console.WriteLine($"{int1}, {int2}");

            string str1 = "First";
            string str2 = "Second";

            Swap(ref str1, ref str2);
            Console.WriteLine($"{str1}, {str2}");

            // Упражнение 5.3
            Console.WriteLine("\nУпражнение 5.3\n");

            Console.Write("Напиши число, у которого нужно найти факториал: ");
            if (int.TryParse(Console.ReadLine(), out int input1))
            {
                if (Factorial(input1, out long factorialResult))
                {
                    Console.WriteLine($"Ответ: {factorialResult}. True");
                }
                else
                {
                    Console.WriteLine("Переполнение. False");
                }
            }

            // Упражнение 5.4
            Console.WriteLine("\nУпражнение 5.4\n");

            Console.Write("Напиши число, у которого нужно найти факториал: ");
            if (int.TryParse(Console.ReadLine(), out int numFact))
            {
                Console.WriteLine(FactorialRekurs(numFact));
            }
            else
            {
                Console.WriteLine("Вы ввели не число.");
            }

            // Дз 5.1
            Console.WriteLine("\nДомашнее задание 5.1\n");

            Console.Write("НОД чисел 48 и 18: ");
            Console.WriteLine(NodCalcul(48,18));

            Console.Write("НОД чисел 48, 18, 15: ");
            Console.WriteLine(NodCalcul(48, 18, 15));


            // Дз 5.2
            Console.WriteLine("\nДомашнее задание 5.2\n");

            Console.Write("Введите значение n-го числа ряда Фибоначчи: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine(Fibonachi(n));
            }


        }
    }
}
