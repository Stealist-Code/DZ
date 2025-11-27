using System;
using System.Security.Policy;

namespace Tumakov.Classes
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publishing { get; set; }

        public Book(string name, string author, string publishing)
        {
            Name = name;
            Author = author;
            Publishing = publishing;
        }
        public override string ToString()
        {
            return $"\"{Name}\" - {Author} ({Publishing})";
        }
    }
}
