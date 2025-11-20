using System;
using System.Linq;
using System.Reflection;
using System.Text;
using Tumakov.Interfaces;

namespace Tumakov.Classes
{
    class BCipher: ICipher
    {
        public string Encode(string input)
        {
            string UpperRus = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string LowerRus = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string UpperEng = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string LowerEng = "abcdefghijklmnopqrstuvwxyz";
            char[] chars = input.ToCharArray();
            StringBuilder output = new StringBuilder();
            foreach (char c in chars)
            {
                if (!Char.IsLetter(c))
                {
                    output.Append(c);
                }
                else if (UpperRus.IndexOf(c) != -1)
                {
                    int newIndex = UpperRus.Length - 1 - UpperRus.IndexOf(c);
                    output.Append(UpperRus[newIndex]);
                }
                else if (LowerRus.IndexOf(c) != -1)
                {
                    int newIndex = LowerRus.Length - 1 - LowerRus.IndexOf(c);
                    output.Append(LowerRus[newIndex]);
                }

                else if (UpperEng.IndexOf(c) != -1)
                {
                    int newIndex = UpperEng.Length - 1 - UpperEng.IndexOf(c);
                    output.Append(UpperEng[newIndex]);
                }
                if (LowerEng.IndexOf(c) != -1)
                {
                    int newIndex = LowerEng.Length - 1 - LowerEng.IndexOf(c);
                    output.Append(LowerEng[newIndex]);
                }
            }
            return output.ToString();
            //Console.WriteLine($"Зашифрованный текст: {output.ToString()}");
        }
        public string Decode(string input)
        {
            string UpperRus = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string LowerRus = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string UpperEng = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string LowerEng = "abcdefghijklmnopqrstuvwxyz";
            char[] chars = input.ToCharArray();
            StringBuilder output = new StringBuilder();
            foreach (char c in chars)
            {
                if (!Char.IsLetter(c))
                {
                    output.Append(c);
                }
                else if (UpperRus.IndexOf(c) != -1)
                {
                    int newIndex = UpperRus.Length - 1 - UpperRus.IndexOf(c);
                    output.Append(UpperRus[newIndex]);
                }
                else if (LowerRus.IndexOf(c) != -1)
                {
                    int newIndex = LowerRus.Length - 1 - LowerRus.IndexOf(c);
                    output.Append(LowerRus[newIndex]);
                }

                else if (UpperEng.IndexOf(c) != -1)
                {
                    int newIndex = UpperEng.Length - 1 - UpperEng.IndexOf(c);
                    output.Append(UpperEng[newIndex]);
                }
                if (LowerEng.IndexOf(c) != -1)
                {
                    int newIndex = LowerEng.Length - 1 - LowerEng.IndexOf(c);
                    output.Append(LowerEng[newIndex]);
                }
            }
            return output.ToString();
            //Console.WriteLine($"Дешифрованный текст: {output.ToString()}");
        }
    }
}
