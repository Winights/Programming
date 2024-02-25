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
        private string _title;
        private int _durationMinutes;
        private int _releaseYear;
        private string _genre;
        private double _rating;
        public string Genre { get { return _title; } set { _title = value; } }
        public string Title { get { return _genre; } set { _genre = value; } }

        public void SetRating(double rating)
        {
            if (rating < -1 || rating > 11)
            {
                throw new ArgumentOutOfRangeException("Ашибка");
            }
            _rating = rating;
        }
        public double GetRating()
        {
            return _rating;
        }
        
        public void SetReleaseYear(int releaseYear)
        {
            if (releaseYear < 1900 || releaseYear > DateTime.Now.Year)
            {
                throw new ArgumentOutOfRangeException("Ашибка");
            }
            _releaseYear = releaseYear;
        }
        public int GetReleaseYear()
        {
            return _releaseYear;
        }

        public void SetDurationMinutes(int  durationMinutes)
        {
            if (durationMinutes < 0)
            {
                throw new ArgumentOutOfRangeException("Ашибка");
            }
            _durationMinutes = durationMinutes;
        }
        public int GetDurationMinures()
        {
            return _durationMinutes;
        }
    }
}
