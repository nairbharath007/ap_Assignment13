using MovieStoreAppSimple.Model;

namespace MovieStoreAppSimple
{
    internal class Program
    {
        private static Movie[] movies = new Movie[5];
        private static int movieCount = 0;
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Display movies");
                Console.WriteLine("2. Add a movie");
                Console.WriteLine("3. Clear all movies");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            DisplayMovies();
                            break;
                        case 2:
                            AddMovie();
                            break;
                        case 3:
                            ClearAllMovies();
                            break;
                        case 4:
                            Console.WriteLine("Exiting the application.");
                            Environment.Exit(0); 
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
                }
            } while (choice != 4);
        }

        static void DisplayMovies()
        {
            if(movieCount == 0)
            {
                Console.WriteLine("No Movies in the store.");
            }
            else
            {
                Console.WriteLine("List of Movies:");
                foreach (var movie in movies)
                {
                    if (movie != null)
                    {
                        Console.WriteLine($"ID: {movie.Id}, Name: {movie.Name}, Genre: {movie.Genre}, Year: {movie.Year}");
                    }
                }
            }   
        }

        static void AddMovie()
        {
            if (movieCount < movies.Length)
            {
                Console.Write("Enter movie name: ");
                string name = Console.ReadLine();
                Console.Write("Enter movie genre: ");
                string genre = Console.ReadLine();
                Console.Write("Enter movie year: ");
                if (int.TryParse(Console.ReadLine(), out int year))
                {
                    Movie movie = new Movie(movieCount + 1, name, genre, year);
                    movies[movieCount++] = movie;
                    Console.WriteLine("Movie added successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid year. Movie not added.");
                }
            }
            else
            {
                Console.WriteLine("Maximum movie limit reached. Cannot add more movies.");
            }
        }

        static void ClearAllMovies()
        {
            Array.Clear(movies, 0, movies.Length);
            movieCount = 0;
            Console.WriteLine("All movies cleared.");
        }
    }
    
}