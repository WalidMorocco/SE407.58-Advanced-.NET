using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    public class BookStoreBookFunctions
    {
        public static void AddBook(Book book)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    context.Books.Add(book);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }

        public static void DeleteBook(Book book)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }

        public static void EditBook(Book book)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    context.Books.Update(book);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
