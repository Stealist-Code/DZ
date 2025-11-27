using System;

namespace Tumakov.Classes
{
    public static class BookCompareType
    {
        // Сравнение по названию
        public static int CompareName(Book book1, Book book2)
        {
            if (book1 == null && book2 != book1)
            {
                return -1;
            }
            else if (book1 == book2)
            {
                return 0;
            }
            else if (book2 == null && book2 != book1)
            {
                return 1;
            }
            return book1.Name.Length.CompareTo(book2.Name.Length);
        }

        // Сравнение по автору
        public static int CompareAuthor(Book book1, Book book2)
        {
            if (book1 == null && book2 != book1)
            {
                return -1;
            }
            else if (book1 == book2)
            {
                return 0;
            }
            else if (book2 == null && book2 != book1)
            {
                return 1;
            }
            return book1.Author.Length.CompareTo(book2.Author.Length);
        }

        // Сравнение по издательству
        public static int ComparePublishing(Book book1, Book book2)
        {
            if (book1 == null && book2 != book1)
            {
                return -1;
            }
            else if (book1 == book2)
            {
                return 0;
            }
            else if (book2 == null && book2 != book1)
            {
                return 1;
            }
            return book1.Publishing.Length.CompareTo(book2.Publishing.Length);
        }
    }
}
