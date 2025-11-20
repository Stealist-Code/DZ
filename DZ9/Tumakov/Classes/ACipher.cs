using System;
using System.Text;
using Tumakov.Interfaces;

namespace Tumakov.Classes
{
    class ACipher: ICipher
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
                    int index = UpperRus.IndexOf(c);
                    int newIndex = (index + 1) % UpperRus.Length;
                    output.Append(UpperRus[newIndex]);
                }
                else if (LowerRus.IndexOf(c) != -1)
                {
                    int index = LowerRus.IndexOf(c);
                    int newIndex = (index + 1) % LowerRus.Length;
                    output.Append(LowerRus[newIndex]);
                }
                else if (UpperEng.IndexOf(c) != -1)
                {
                    int index = UpperEng.IndexOf(c);
                    int newIndex = (index + 1) % UpperEng.Length;
                    output.Append(UpperEng[newIndex]);
                }
                else if (LowerEng.IndexOf(c) != -1)
                {
                    int index = LowerEng.IndexOf(c);
                    int newIndex = (index + 1) % LowerEng.Length;
                    output.Append(LowerEng[newIndex]);
                }
                else
                {
                    output.Append(c);
                }
            }
            return output.ToString();

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
                    int index = UpperRus.IndexOf(c);
                    int newIndex = (index - 1 + UpperRus.Length) % UpperRus.Length;
                    output.Append(UpperRus[newIndex]);
                }
                else if (LowerRus.IndexOf(c) != -1)
                {
                    int index = LowerRus.IndexOf(c);
                    int newIndex = (index - 1 + LowerRus.Length) % LowerRus.Length;
                    output.Append(LowerRus[newIndex]);
                }
                else if (UpperEng.IndexOf(c) != -1)
                {
                    int index = UpperEng.IndexOf(c);
                    int newIndex = (index - 1 + UpperEng.Length) % UpperEng.Length;
                    output.Append(UpperEng[newIndex]);
                }
                else if (LowerEng.IndexOf(c) != -1)
                {
                    int index = LowerEng.IndexOf(c);
                    int newIndex = (index - 1 + LowerEng.Length) % LowerEng.Length;
                    output.Append(LowerEng[newIndex]);
                }
                else
                {
                    output.Append(c);
                }
            }
            return output.ToString();
        }
    }
}
