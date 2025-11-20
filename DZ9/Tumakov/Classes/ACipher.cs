using System;
using System.Text;
using Tumakov.Interfaces;

namespace Tumakov.Classes
{
    class ACipher: ICipher
    {
        public void Encode(string input)
        {
            char charConverted;
            char[] chars = input.ToCharArray();
            StringBuilder output = new StringBuilder();
            foreach (char c in chars)
            {
                if (!Char.IsLetter(c))
                {
                    output.Append(c);
                }
                else if (c == 'ё')
                {
                    output.Append('ж');
                }
                else if (c == 'Ё')
                {
                    output.Append('Ж');
                }
                else if (Char.IsLower(c))
                {
                    charConverted = (c <= 'z') ? (char)((c + 1) % 32 + 'a') : (char)((c + 1) % 32 + 'а');
                    output.Append(charConverted);
                }
                else
                {
                    charConverted = (c <= 'Z') ? (char)((c + 1) % 32 + 'A') : (char)((c + 1) % 32 + 'А');
                    output.Append(charConverted);
                }
            }
            Console.WriteLine(output.ToString());
        }
        public void Decode()
        {

        }
    }
}
