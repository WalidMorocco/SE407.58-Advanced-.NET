using BlockBuster;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BlockBusterTest
{
    public class BlockBusterBasicFunctionsTest
    {
        [Fact]
        public void GetMoviesByIdTest()
        {
            var result = BlockBusterBasicFunctions.GetMovieById(11);
            Assert.True(result.Title == "Vertigo");
            Assert.True(result.ReleaseYear == 1958);
        }

        [Fact]
        public void GetAllMovies()
        {
            var result = BlockBusterBasicFunctions.GetAllMovies();
            Assert.True(result.Count == 49);
        }

        [Fact]
        public void GetAllCheckedOutMovies()
        {
            var result = BlockBusterBasicFunctions.GetAllCheckedOutMovies();
            Assert.True(result.Count == 3);
        }

        [Fact]
        public void GetAllMoviesByGenreDesc()
        {
            var result = BlockBusterBasicFunctions.GetAllMoviesByGenreDesc("Sci-Fi");
            Assert.True(result.Count == 1);
        }

        [Fact]
        public void GetAllMoviesByDirectorLastName()
        {
            var result = BlockBusterBasicFunctions.GetAllMoviesByDirectorLastName("Coppola");
            Assert.True(result.Count == 2);
        }
    }
}
