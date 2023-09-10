using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge28
{
    public class MovieSortClass
    {
        public class Movie
        {
            public string Title { get; set; }
            public int Year { get; set; }
            public List<string> Genres { get; set; }

        }



        public class Sorting
        {


            public static List<Movie> SortByYear(List<Movie> movies)
            {
                for (int i = 0; i < movies.Count - 1; i++)
                {
                    for (int j = 0; j < movies.Count - i - 1; j++)
                    {
                        if (movies[j].Year > movies[j + 1].Year)
                        {
                            Movie temp = movies[j];
                            movies[j] = movies[j + 1];
                            movies[j + 1] = temp;
                        }
                    }
                }
                return movies;
            }

            public static List<Movie> SortByName(List<Movie> movies)
            {


                string[] skipWord = { "The", "An", "A" };

                for (int i = 0; i < movies.Count - 1; i++)
                {
                    for (int j = 0; j < movies.Count - i - 1; j++)
                    {
                        string firstOne = movies[j].Title;
                        string secondOne = movies[j + 1].Title;

                        foreach (string word in skipWord)
                        {
                            firstOne = firstOne.Replace($"{word} ", "");
                            secondOne = secondOne.Replace($"{word} ", "");
                        }

                        if (CompareTitles(firstOne, secondOne) > 0)
                        {
                            Movie temp = movies[j];
                            movies[j] = movies[j + 1];
                            movies[j + 1] = temp;
                        }
                    }
                }
                return movies;
            }

            public static int CompareTitles(string firstMovie, string secondMovie)
            {
                for (int i = 0; i < Math.Min(firstMovie.Length, secondMovie.Length); i++)
                {
                    if (firstMovie[i] < secondMovie[i])
                    {
                        return -1;
                    }
                    else if (firstMovie[i] > secondMovie[i])
                    {
                        return 1;
                    }
                }

                return 0;
            }


            public bool FirstPart(string str)
            {
                if (str == "The" || str == "A" || str == "An")
                    return true;
                else return false;
            }

        }

    }
}
