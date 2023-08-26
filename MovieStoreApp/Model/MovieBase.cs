using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Model
{
    internal abstract class MovieBase
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public double ImdbRating { get; set; }

        public MovieBase(string title, int year, double imdbRating)
        {
            Title = title;
            Year = year;
            ImdbRating = imdbRating;
        }

        //public abstract void DisplayInfo();
        public abstract string DisplayInfo();


    }
}
