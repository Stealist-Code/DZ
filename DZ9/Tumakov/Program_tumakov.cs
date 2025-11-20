using System;
using Tumakov.Classes;
using Tumakov.Interfaces;

namespace Tumakov
{
    internal class Program_tumakov
    {
        static void Exercise_10()
        {
            Console.WriteLine("Упражнение 10\n");
            Console.Write("Текст для шифрования ACipher: ");
            string textForACipher = Console.ReadLine();
            var aCipherObject = new ACipher();
            aCipherObject.Encode(textForACipher);

            Console.Write("Текст для шифрования BCipher: ");
            string textForBCipher = Console.ReadLine();
            var bCipherObject = new BCipher();
            bCipherObject.Encode(textForBCipher);
        }

        static void HomeWork_10()
        {
            Console.WriteLine("Домашняя работа 10\n");
            var point = new Point(System.Drawing.Color.Blue, Enums.Status.Visible, new float[2] { 0, 0 });
            point.MoveVertical(10);
            point.ChangeColor(System.Drawing.Color.Purple);

            var circle = new Circle(System.Drawing.Color.Red, Enums.Status.Invisible, new float[2] { 0, 0 }, 3);
            circle.MoveVertical(20);
            circle.ChangeColor(System.Drawing.Color.Green);

            var rectangle = new Rectangle(System.Drawing.Color.Red, Enums.Status.Visible, new float[2] { 0, 0 }, 10, 3);
            rectangle.MoveHorizontal(50);
            rectangle.GetInfo();
        }
        
        static void Main(string[] args)
        {
            Exercise_10();
            HomeWork_10();
        }
    }
}
