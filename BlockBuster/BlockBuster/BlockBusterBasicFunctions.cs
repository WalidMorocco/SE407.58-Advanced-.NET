using BlockBuster.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlockBuster
{
    public class BlockBusterBasicFunctions
    {
        public static Movie GetMovieById(int id)
        {
            try
            {
                using(var context = new SE407_BlockBusterContext())
                {
                    return context.Movies.Find(id);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static Movie GetMovieByIdFull(int id)
        {
            try
            {
                using (var context = new SE407_BlockBusterContext())
                {
                    return context.Movies
                        .Include(m => m.Genre)
                        .Include(m => m.Director)
                        .Where(m => m.MovieId == id)
                        .FirstOrDefault();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<Movie> GetAllMovies()
        {
            try
            {
                using (var context = new SE407_BlockBusterContext())
                {
                    return context.Movies.ToList();
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
                using (var context = new SE407_BlockBusterContext())
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
        public static List<Director> GetAllDirectors()
        {
            try
            {
                using (var context = new SE407_BlockBusterContext())
                {
                    return context.Directors.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<Movie> GetAllCheckedOutMovies()
        {
            try
            {
                using (var context = new SE407_BlockBusterContext())
                {
                    return context.Movies
                        .Join(context.Transactions,
                        m => m.MovieId,
                        t => t.Movie.MovieId,
                        (m, t) => new
                        {
                            MovieId = m.MovieId,
                            Title = m.Title,
                            ReleaseYear = m.ReleaseYear,
                            GenreId = m.GenreId,
                            DirectorId = m.DirectorId,
                            CheckedIn = t.CheckedIn
                        }).Where(w => w.CheckedIn == "N")
                        .Select(m => new Movie
                        {
                            MovieId = m.MovieId,
                            Title = m.Title,
                            ReleaseYear = m.ReleaseYear,
                            GenreId = m.GenreId,
                            DirectorId = m.DirectorId,
                        }).ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<Movie> GetAllMoviesByGenreDesc(string desc)
        {
            try
            {
                using (var context = new SE407_BlockBusterContext())
                {
                    return context.Movies
                        .Join(context.Genres,
                        m => m.GenreId,
                        g => g.GenreId,
                        (m, g) => new
                        {
                            MovieId = m.MovieId,
                            Title = m.Title,
                            ReleaseYear = m.ReleaseYear,
                            GenreId = m.GenreId,
                            GenreDescr = g.GenreDescr,
                            DirectorId = m.DirectorId,
                        }).Where(g => g.GenreDescr.Equals(desc))
                        .Select(m => new Movie
                        {
                            MovieId = m.MovieId,
                            Title = m.Title,
                            ReleaseYear = m.ReleaseYear,
                            GenreId = m.GenreId,
                            DirectorId = m.DirectorId,
                        }).ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<Movie> GetAllMoviesByDirectorLastName(string lastname)
        {
            try
            {
                using (var context = new SE407_BlockBusterContext())
                {
                    return context.Movies
                        .Join(context.Directors,
                        m => m.DirectorId,
                        d => d.DirectorId,
                        (m, d) => new
                        {
                            MovieId = m.MovieId,
                            Title = m.Title,
                            ReleaseYear = m.ReleaseYear,
                            GenreId = m.GenreId,
                            LastName = d.LastName,
                            DirectorId = m.DirectorId,
                        }).Where(d => d.LastName.Equals(lastname))
                        .Select(m => new Movie
                        {
                            MovieId = m.MovieId,
                            Title = m.Title,
                            ReleaseYear = m.ReleaseYear,
                            GenreId = m.GenreId,
                            DirectorId = m.DirectorId,
                        }).ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<Movie> GetAllMoviesFull()
        {
            try
            {
                using (var context = new SE407_BlockBusterContext())
                {
                    var movies = context.Movies
                        .Include(movies => movies.Director)
                        .Include(movies => movies.Genre)
                        .ToList();

                    return movies;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<Transaction> GetCheckedOutMovies()
        {
            try
            {
                using (var context = new SE407_BlockBusterContext())
                {
                    var movieList = context.Transactions
                        .Where(t => t.CheckedIn == "N")
                        .Include(t => t.Movie)
                        .Include(t => t.Customer)
                        .ToList();
                    return movieList;
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
