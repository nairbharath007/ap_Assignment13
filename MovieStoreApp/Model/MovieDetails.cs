using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Model
{
    internal class MovieDetails : MovieBase
    {
        public string Genre { get; set; }
        public string Cast { get; set; }
        public string Plot { get; set; }
        public int DurationMinutes { get; set; }

        public MovieDetails(string title, string genre, int year, string cast, string plot, int durationMinutes, double imdbRating)
            : base(title, year, imdbRating)
        {
            Genre = genre;
            Cast = cast;
            Plot = plot;
            DurationMinutes = durationMinutes;
        }

        public override string DisplayInfo()
        {
            return $"{Title} ({Year}) - {Genre}\n" +
                   $"Cast: {Cast}\n" +
                   $"Plot: {Plot}\n" +
                   $"Duration: {DurationMinutes} minutes\n" +
                   $"IMDb Rating: {ImdbRating}";
        }

        /*public override void DisplayInfo()
        {
            Console.WriteLine($"  {Title} ({Year}) - {Genre}");
            Console.WriteLine($"  Cast: {Cast}");
            Console.WriteLine($"  Plot: {Plot}");
            Console.WriteLine($"  Duration: {DurationMinutes} minutes");
            Console.WriteLine($"  IMDb Rating: {ImdbRating}");
        }*/

    }
}
