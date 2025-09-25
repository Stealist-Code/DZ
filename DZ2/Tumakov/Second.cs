using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov
{
    public class Second
    {
        // Упражнение 3.1
        public enum bankAccount
        {
            Current,
            Saving,
        }

        // Упражнение 3.2
        public struct infoBankAccount
        {
            public int number;
            public string type;
            public int balance;
        }

        // Дз 3.1
        public enum university
        {
            KSU = 1,
            KAI = 2,
            KHTI = 3,
        }

        public struct worker
        {
            public string name;
            public university univ;
        }
    }
}
