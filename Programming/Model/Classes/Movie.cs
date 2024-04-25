using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильмах.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Продолжительность фильма в минутах для всех объектов данного класса.
        /// </summary>
        private int _durationMinutes;

        /// <summary>
        /// Дата выхода фильма для всех объектов данного класса.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Рейтинг фильма для всех объектов данного класса.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Жанр фильма для всех объектов данного класса.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Название фильма для всех объектов данного класса.
        /// </summary>
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
