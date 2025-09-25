using System;
using static Practice.struct_enum;


namespace Practice
{
    internal class struct_enum
    {

        public enum categoryBewerage
        {
            nonalcoholic,
            alcoholic,
        }

        public struct lemonade
        {
            public categoryBewerage type;
            public float alcohol;
        }

        public struct beer
        {
            public categoryBewerage type;
            public float alcohol;
        }

        public struct wine
        {
            public categoryBewerage type;
            public float alcohol;
        }
        public struct Students
        {
            public string surname;
            public string name;
            public int id;
            public string dateBirth;
            public string categAlcohol;
            public float volume;
        }


    }

    
}

