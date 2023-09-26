using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Module04.Classes.Practice_work
{
    class HomeLibrary
    {
        private List<Book> books;

        public HomeLibrary()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public List<Book> FindBooksByAuthor(string author)
        {
            return books.Where(b => b.Author == author).ToList();
        }


        public List<Book> FindBooksByYear(int year)
        {
            return books.Where(b => b.Year == year).ToList();
        }

        public List<Book> FindBooksByTitle(string title)
        {
            return books.Where(b => b.Title == title).ToList();
        }

        public List<Book> SortBooksByTitle()
        {
            return books.OrderBy(b => b.Title).ToList();
        }

        public List<Book> SortBooksByAuthor()
        {
            return books.OrderBy(b => b.Author).ToList();
        }

        public List<Book> SortBooksByYear()
        {
            return books.OrderBy(b => b.Year).ToList();
        }

        public void DisplayBooks(List<Book> bookList)
        {
            foreach (Book book in bookList)
            {
                Console.WriteLine($"Название: {book.Title}");
                Console.WriteLine($"Автор: {book.Author}");
                Console.WriteLine($"Год издания: {book.Year}");
                Console.WriteLine($"Жанр: {book.Genre}");
                Console.WriteLine();
            }
        }
    }
}
