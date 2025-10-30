using System;
using System.Xml.Linq;

namespace Tumakov.Classes
{
    class Song
    {
        private string _name;
        private string _author;
        private Song _prev;
        
        public Song (string name, string author, Song prev = null)
        {
            _name = name;
            _author = author;
            _prev = prev;
        }

        public void SetName(string name)
        {
            _name = name;
        }
        public void SetAuthor(string author)
        {
            _author = author;
        }
        public void SetPrev(Song prev)
        {
            _prev = prev;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Название песни: {_name}\nАвтор песни: {_author}");
        }
        public string Title()
        {
            return $"{_name} - {_author}";
        }
        public override bool Equals(object d)
        {
            if (d is Song other)
            {
                return _name == other._name && _author == other._author;
            }
            return false;
        }
    }
}
