using System;
using static Practice.Enum_Struct.Enum;

namespace Practice.Enum_Struct
{
    internal class Struct
    {
        public struct Ded
        {
            public string name;
            public Grumpiness grumpy;
            public string[] vocabularyArray;
            public int quantityBruises;

            public Ded(string name, Grumpiness grumpy, string[] vocabularyArray)
            {
                this.name = name;
                this.grumpy = grumpy;
                this.vocabularyArray = vocabularyArray;
                this.quantityBruises = 0;
            }

            public static int Kick(Ded ded, params string[] swearingArray)
            {
               foreach (string word in ded.vocabularyArray)
               {
                   if (Array.IndexOf(swearingArray, word) != -1)
                   {
                       ded.quantityBruises++;
                   }
               }
               return ded.quantityBruises;
            }
        }
    }
}
