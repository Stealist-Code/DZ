using System;
using System.Xml.Linq;

namespace Tumakov.Classes
{
    class Song
    {
        public string Name { get; private set; }
        public string Author { get; private set; }
        public Song Prev { get; private set; }

        public Song(string name, string author)
        {
            Name = name;
            Author = author;
            Prev = null;
        }

        public Song(string name, string author, Song prev)
        {
            Name = name;
            Author = author;
            Prev = prev;
        }

        public Song()
        {
            Name = "None";
            Author = "None";
            Prev = null;
        }

        public void SetName(string name)
        {
            Name = name;
        }
        public void SetAuthor(string author)
        {
            Author = author;
        }
        public void SetPrev(Song prev)
        {
            Prev = prev;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Название песни: {Name}\nАвтор песни: {Author}");
        }
        public string Title()
        {
            return $"{Name} - {Author}";
        }
        public override bool Equals(object d)
        {
            if (d is Song other)
            {
                return Name == other.Name && Author == other.Author;
            }
            return false;
        }
    }
}