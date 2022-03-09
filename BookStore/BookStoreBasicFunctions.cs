using BookStore.Models;
using Microsoft.EntityFrameworkCore;
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

        public static Book GetBookByIdFull(int id)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    return context.Books
                        .Include(m => m.Genre)
                        .Include(m => m.Author)
                        .Where(m => m.BookId == id)
                        .FirstOrDefault();

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

        public static List<Book> GetAllBooksFull()
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    var books = context.Books
                        .Include(books => books.Author)
                        .Include(books => books.Genre)
                        .ToList();

                    return books;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<Genre> GetAllGenres()
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    return context.Genres.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<Author> GetAllAuthors()
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    return context.Authors.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static Genre GetGenreByIdFull(int id)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    return context.Genres
                        .Where(m => m.GenreId == id)
                        .FirstOrDefault();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static Author GetAuthorByIdFull(int id)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    return context.Authors
                        .Where(m => m.AuthorId == id)
                        .FirstOrDefault();

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
