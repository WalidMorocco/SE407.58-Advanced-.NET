using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore
{
    public class BookStoreBasicFunctions
    {
        public static Book GetBookByTitle(string title)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    return context.Books.First<Book>(t => t.BookTitle == title);
                }
            }   
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<Book> GetAllBooks()
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    return context.Books.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<Book> GetAllBooksByAuthorLastName(string lastname)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    return context.Books
                        .Join(context.Authors,
                        m => m.AuthorId,
                        d => d.AuthorId,
                        (m, d) => new
                        {
                            BookId = m.BookId,
                            BookTitle = m.BookTitle,
                            YearOfRelease = m.YearOfRelease,
                            GenreId = m.GenreId,
                            AuthorLast = d.AuthorLast,
                            AuthorId = m.AuthorId,
                        }).Where(d => d.AuthorLast.Equals(lastname))
                        .Select(m => new Book
                        {
                            BookId = m.BookId,
                            BookTitle = m.BookTitle,
                            YearOfRelease = m.YearOfRelease,
                            GenreId = m.GenreId,
                            AuthorId = m.AuthorId,
                        }).ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
