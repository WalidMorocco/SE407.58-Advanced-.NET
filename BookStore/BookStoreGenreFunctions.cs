using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    public class BookStoreGenreFunctions
    {
        public static void AddGenre(Genre genre)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    context.Genres.Add(genre);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }

        public static void DeleteGenre(Genre genre)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    context.Genres.Remove(genre);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }

        public static void EditGenre(Genre genre)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    context.Genres.Update(genre);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
