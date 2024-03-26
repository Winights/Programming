using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private int _durationMinutes;
        private int _releaseYear;
        private double _rating;
        public string Genre { get; set; }
        public string Title { get; set; }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Rating");
                _rating = value;
            }
        }
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, "Release");
                _releaseYear = value;
            }
        }
        public int DurationMinutes
        {
            get
            {
                return _durationMinutes;
            }
            set 
            {
                Validator.AssertOnPositiveValue(value, "DurationMinutes");
                _durationMinutes = value;
            }
        }
        public Movie(int durationMinutes, int releaseYear, double rating, string genre, string title)
        {
            DurationMinutes = durationMinutes; 
            ReleaseYear = releaseYear;
            Rating = rating;
            Genre = genre;
            Title = title;
        }
        public Movie()
        {
            DurationMinutes = 0;
            ReleaseYear = 1900;
            Rating = 0;
            Genre = "";
            Title = "";
        }
    }
}
