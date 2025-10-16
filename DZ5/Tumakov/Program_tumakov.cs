using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tumakov
{
    internal class Program_tumakov
    {

        static void Exercise_6_1(out int vowelsCount, out int consonantCount, char[] lettersArray)
        {
            vowelsCount = 0;
            consonantCount = 0;
            char[] vowels = { 'а', 'о', 'у', 'ы', 'э', 'я', 'е', 'ё', 'ю', 'и', 'e', 'y', 'u', 'i', 'o', 'a' };
            
            foreach (char letters in lettersArray)
            {
                if (char.IsLetter(letters))
                {
                    char lettersLower = char.ToLower(letters);
                    if (vowels.Contains(lettersLower))
                    {
                        vowelsCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int currentCol = 0;

            foreach (int element in matrix)
            {
                Console.Write(element + " ");
                currentCol++;

                if (currentCol == cols)
                {
                    Console.WriteLine();
                    currentCol = 0;
                }
            }
        }

        static int[,] CompositionMatrix(int[,] matrix1, int[,] matrix2)
        {
            int rowsA = matrix1.GetLength(0);
            int colsA = matrix1.GetLength(1);
            int rowsB = matrix2.GetLength(0);
            int colsB = matrix2.GetLength(1);

            if (colsA != rowsB)
            {
                return null;  // Матрицы несовместимы
            }

            int[,] matrix = new int[rowsA, colsB];
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    matrix[i, j] = sum;
                }
            }

            return matrix;
        }

        static float[] Exercise_6_3()
        {
            Random random = new Random();
            int[,] temperatureMouths = new int[12, 30];
            for (int i = 0; i < temperatureMouths.GetLength(0); i++)
            {
                for (int j = 0; j < temperatureMouths.GetLength(1); j++)
                {
                    temperatureMouths[i, j] = random.Next(-30, 30);
                } 
            }

            float[] temperatAver = TemperatureAverage(temperatureMouths);
            Array.Sort(temperatAver);
            return temperatAver;
        }

        static float[] TemperatureAverage(int[,] temprature)
        {
            float[] temperatAver = new float[temprature.GetLength(0)];
            
            for (int i = 0; i < temprature.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < temprature.GetLength(1); j++)
                {
                    sum += temprature[i, j];
                }
                temperatAver[i] = (float)sum / temprature.GetLength(1);

            }
            return temperatAver;
        }

        static void HomeWork_6_1(out int vowelsCount, out int consonantCount, List<char> lettersArray)
        {
            vowelsCount = 0;
            consonantCount = 0;
            char[] vowels = { 'а', 'о', 'у', 'ы', 'э', 'я', 'е', 'ё', 'ю', 'и', 'e', 'y', 'u', 'i', 'o', 'a' };

            foreach (char letters in lettersArray)
            {
                if (char.IsLetter(letters))
                {
                    char lettersLower = char.ToLower(letters);
                    if (vowels.Contains(lettersLower))
                    {
                        vowelsCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }
        }

        static void PrintMatrixLinkedList(LinkedList<LinkedList<int>> matrix)
        {
            if (matrix == null || matrix.Count == 0)
            {
                Console.WriteLine("Матрица пуста.");
                return;
            }
            foreach (var row in matrix)
            {
                if (row != null)
                {
                    foreach (var element in row)
                    {
                        Console.Write(element + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        static LinkedList<LinkedList<int>> CompositionMatrixLinkedList(LinkedList<LinkedList<int>> matrix1, LinkedList<LinkedList<int>> matrix2)
        {
            int rowsA = matrix1.Count;
            int colsA = matrix1.First.Value.Count;
            int rowsB = matrix2.Count;
            int colsB = matrix2.First.Value.Count;

            if (colsA != rowsB)
            {
                return null;  // Матрицы несовместимы
            }

            LinkedList<LinkedList<int>> matrix = new LinkedList<LinkedList<int>>();
            for (int i = 0; i < rowsA; i++)
            {
                LinkedList<int> matrixRow = new LinkedList<int>();
                for (int j = 0; j < colsB; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        int elementA = matrix1.ElementAt(i).ElementAt(k);
                        int elementB = matrix2.ElementAt(k).ElementAt(j);
                        sum += elementA * elementB;
                    }
                    matrixRow.AddLast(sum);
                }
                matrix.AddLast(matrixRow);
            }

            return matrix;
        }

        static float[] HomeWork_6_3()
        {
            Random random = new Random();
            Dictionary<string, int[]> mouthsTemperat = new Dictionary<string, int[]>();
            string[] mouthsName = {"Январь","Февраль","Март","Апрель","Май","Июнь","Июль","Август","Сентябрь","Октябрь","Ноябрь","Декабрь"};
            for (int i = 0; i < mouthsName.Length; i++)
            {
                int[] temperat = new int[30];
                for (int j = 0;j < temperat.Length; j++)
                {
                    temperat[j] = random.Next(-30,30); 
                }
                mouthsTemperat.Add(mouthsName[i],temperat);
            }
            float[] temperatAver = TemperatureAverage(mouthsTemperat);
            Array.Sort(temperatAver);
            return temperatAver;
        }
        static float[] TemperatureAverage(Dictionary<string, int[]> mouthsTemperat)
        {
            float[] temperatAver = new float[mouthsTemperat.Count];
            int i = 0;
            foreach (var temperat in mouthsTemperat)
            {
                int sum = temperat.Value.Sum();
                temperatAver[i] = (float)sum / temperat.Value.Length;
                i++;
            }
            return temperatAver;
        }

        static void Main(string[] args)
        {
            // Упражнение 6.1
            Console.WriteLine("Упражнение 6.1\n");

            string fileName = args.Length > 0 ? args[0] : @"..\..\Files\Text.txt";
            string textFromFile = File.ReadAllText(fileName);
            char[] lettersArray = textFromFile.ToCharArray();

            Exercise_6_1(out int vowelsCount, out int consonantCount, lettersArray);
            Console.WriteLine($"В данном текстовом файле гласных {vowelsCount} шт, а согласных {consonantCount} шт");

            // Упражнение 6.2
            Console.WriteLine("\nУпражнение 6.2\n");

            int[,] matrix1 = new int[2,2]{ {7,6}, {4,3} };
            int[,] matrix2 = new int[2,2]{ {2,7}, {1,3} };

            int[,] matrix = CompositionMatrix(matrix1, matrix2);
            Console.WriteLine("Первая матрица: ");
            PrintMatrix(matrix1);
            Console.WriteLine("\nВторая матрица: ");
            PrintMatrix(matrix2);
            Console.WriteLine("\nПолученная при умножении матрица: ");
            PrintMatrix(matrix);

            // Упражнение 6.3
            Console.WriteLine("\nУпражнение 6.3\n");

            float[] temperatAver = Exercise_6_3();
            Console.WriteLine("Средняя температура: ");
            foreach(int temperat in temperatAver)
            {
                Console.Write($" {temperat}");
            }
            // Домашнее задание 6.1
            Console.WriteLine("\n\nДомашнее задание 6.1\n");

            string textFromFile2 = File.ReadAllText(@"..\..\Files\Text.txt");
            List<char> lettersList = new List<char>(textFromFile2);
            HomeWork_6_1(out int vowels, out int consonants, lettersList);
            Console.WriteLine($"В данном текстовом файле гласных {vowels} шт, а согласных {consonants} шт");

            // Домашнее задание 6.2
            Console.WriteLine("\nДомашнее задание 6.2\n");

            LinkedList<LinkedList<int>> matrixHW1 = new LinkedList<LinkedList<int>>();
            matrixHW1.AddLast(new LinkedList<int>(new[] { 1, 2, 3 }));
            matrixHW1.AddLast(new LinkedList<int>(new[] { 7, 8, 9 }));

            LinkedList<LinkedList<int>> matrixHW2 = new LinkedList<LinkedList<int>>();
            matrixHW2.AddLast(new LinkedList<int>(new[] { 7, 8 }));
            matrixHW2.AddLast(new LinkedList<int>(new[] { 9, 10 }));
            matrixHW2.AddLast(new LinkedList<int>(new[] { 11, 12 }));

            LinkedList<LinkedList<int>> matrixHW = CompositionMatrixLinkedList(matrixHW1, matrixHW2);
            Console.WriteLine("При умножении 2-х матриц получилась матрица: ");
            PrintMatrixLinkedList(matrixHW);

            // Домашнее задание 6.3
            Console.WriteLine("\nДомашнее задание 6.3\n");

            float[] temperatAverDictionary = HomeWork_6_3();
            Console.WriteLine("Средняя температура: ");
            foreach (int temperat in temperatAverDictionary)
            {
                Console.Write($" {temperat}");
            }
        }
    }
}
