using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Model
{
    internal class MovieStore
    {
        private MovieDetails[] movieStore;
        private int movieCount;

        public MovieStore()
        {
            movieStore = new MovieDetails[5];
            movieCount = 0;
        }

        public void AddMovie()
        {
            if (movieCount < 5)
            {
                Console.Write("Enter movie title: ");
                string title = Console.ReadLine();
                Console.Write("Enter movie genre: ");
                string genre = Console.ReadLine();
                Console.Write("Enter movie release year: ");
                if (int.TryParse(Console.ReadLine(), out int year))
                {
                    Console.Write("Enter movie cast: ");
                    string cast = Console.ReadLine();
                    Console.Write("Enter movie plot: ");
                    string plot = Console.ReadLine();
                    Console.Write("Enter movie duration (minutes): ");
                    if (int.TryParse(Console.ReadLine(), out int duration))
                    {
                        Console.Write("Enter IMDb rating: ");
                        if (double.TryParse(Console.ReadLine(), out double imdbRating))
                        {
                            MovieDetails newMovie = new MovieDetails(title, genre, year, cast, plot, duration, imdbRating);
                            movieStore[movieCount] = newMovie;
                            movieCount++;
                            Console.WriteLine("Movie added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid IMDb rating format. Movie not added.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid duration format. Movie not added.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid year format. Movie not added.");
                }
            }
            else
            {
                Console.WriteLine("Movie store is full. Cannot add more movies.");
            }
        }
        public void DeleteMovie(int index)
        {
            if (index >= 0 && index < movieCount)
            {
                for (int i = index; i < movieCount - 1; i++)
                {
                    movieStore[i] = movieStore[i + 1];
                }
                movieCount--;
                Console.WriteLine("Movie deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid movie index. Movie not deleted.");
            }
        }

        public void DisplayMovies()
        {
            if (movieCount > 0)
            {
                Console.WriteLine("Movies in the store:");
                for (int i = 0; i < movieCount; i++)
                {
                    //Console.WriteLine(movieStore[i]);
                    Console.WriteLine($"Index: {i}");
                    movieStore[i].DisplayInfo();
                    Console.WriteLine(); 
                }
            }
            else
            {
                Console.WriteLine("Movie store is empty.");
            }
        }
    }
}
