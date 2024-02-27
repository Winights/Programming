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
                if (value < -1 || value > 11)
                {
                    throw new ArgumentOutOfRangeException("Ашибка");
                }
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
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentOutOfRangeException("Ашибка");
                }
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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ашибка");
                }
                _durationMinutes = value;
            }
        }
    }
}
