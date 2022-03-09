using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    public class BookStoreAuthorFunctions
    {
        public static void AddAuthor(Author author)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    context.Authors.Add(author);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }

        public static void DeleteAuthor(Author author)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    context.Authors.Remove(author);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }

        public static void EditAuthor(Author author)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    context.Authors.Update(author);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
