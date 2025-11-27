using System;
using System.Collections.Generic;

namespace Tumakov.Classes
{
    
    public class ContainerForBooks
    {
        public Book[] Books { get; private set; } = new Book[0];

        public ContainerForBooks(params Book[] books)
        {
            Books = books;
        }

        public void SortBooks(BookComparison comparison)
        {
            CheckArrayNull();
            if (comparison == null)
            {
                Console.WriteLine("Сортировка не произошла. Нужно задать критерий сортировки!");
                return;
            }

            for (int i = 0; i < Books.Length - 1; i++)
            {
                for (int j = 0; j < Books.Length - i - 1; j++)
                {
                    if (comparison(Books[j], Books[j + 1]) > 0)
                    {
                        Book temp = Books[j];
                        Books[j] = Books[j + 1];
                        Books[j + 1] = temp;
                    }
                }
            }
        }
        public void PrintBooks()
        {
            Console.WriteLine("Список книг:");
            for (int i = 0; i < Books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Books[i]}");
            }
            Console.WriteLine();
        }
        public void CheckArrayNull()
        {
            Console.WriteLine("Проверка на null ---");
            var booksCheck = new List<Book>();
            var availabilityNull = false;
            foreach (var book in Books)
            {
                if (book != null)
                {
                    booksCheck.Add(book);
                }
                else
                {
                    availabilityNull = true;
                }
            }
            if (availabilityNull)
            {
                Books = booksCheck.ToArray();
            }
        }
    }
}
