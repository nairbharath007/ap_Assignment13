using MovieStoreApp.Model;

namespace MovieStoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieStore movieStore = new MovieStore();
            bool exit = false;

            while (!exit)
            {
                PrintMenu();
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            movieStore.AddMovie();
                            break;
                        case 2:
                            movieStore.DisplayMovies();
                            break;
                        case 3:
                            Console.Write("Enter the index of the movie to delete: ");
                            if (int.TryParse(Console.ReadLine(), out int deleteIndex))
                            {
                                movieStore.DeleteMovie(deleteIndex);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Movie not deleted.");
                            }
                            break;
                        case 4:
                            exit = true;
                            Console.WriteLine("Exiting the movie store application.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number (1, 2, or 3).");
                }

                Console.WriteLine();

            }
            static void PrintMenu()
            {
                Console.WriteLine("Movie Store Menu:");
                Console.WriteLine("1. Add a movie");
                Console.WriteLine("2. Display all movies");
                Console.WriteLine("3. Delete a movie");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
            }
        }
    }
}
