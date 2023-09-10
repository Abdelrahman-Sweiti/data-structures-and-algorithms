using MovieSort;
using System.Collections.Generic;
using System.Linq;
using static CodeChallenge28.MovieSortClass;
using Assert = Xunit.Assert;

namespace MovieSort.Tests
{
    public class UnitTest1
    {

        public class Sort
        {
            [Fact]
            public void SortByNameTest()
            {

                var movies = new List<Movie>
            {
                new Movie { Title = "An BMovie" },
                new Movie { Title = "The CMovie" },
                new Movie { Title = "A AMovie" },
                new Movie { Title = "A DMovie" },
                new Movie { Title = "EMovie" }
            };


                var sortedMovies = Sorting.SortByName(movies);

                Assert.Equal("A AMovie", sortedMovies[0].Title);
                Assert.Equal("An BMovie", sortedMovies[1].Title);
                Assert.Equal("The CMovie", sortedMovies[2].Title);
                Assert.Equal("A DMovie", sortedMovies[3].Title);
                Assert.Equal("EMovie", sortedMovies[4].Title);
            }

            [Fact]
            public void CompareTitlesTest()
            {
                string title1 = "A Movie";
                string title2 = "E Movie";

                var result = Sorting.CompareTitles(title1, title2);
                Assert.True(result < 0);
            }

            [Fact]
            public void SortByYear_ShouldSortMoviesByYear()
            {

                var movies = new List<Movie>
            {
                new Movie { Title = "An B Movie", Year = 2001 },
                new Movie { Title = "The C Movie", Year = 2000 },
                new Movie { Title = "A Movie", Year = 1997 },
                new Movie { Title = "A D Movie", Year = 1979 },
                new Movie { Title = "E Movie", Year = 2005 }
            };


                var sortedMovies = Sorting.SortByYear(movies);


                Assert.Equal(1979, sortedMovies[0].Year);
                Assert.Equal(1997, sortedMovies[1].Year);
                Assert.Equal(2000, sortedMovies[2].Year);
                Assert.Equal(2001, sortedMovies[3].Year);
                Assert.Equal(2005, sortedMovies[4].Year);
            }
        }
    }
}