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
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _durationMinutes;

        /// <summary>
        /// Год выхода фильма.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задает рейтинг фильма. Должен быть положительным числом и не больше 10.
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Rating");
                Validator.AssertValueInRange(value, 0, 10, "Rating");
                _rating = value;
            }
        }

        /// <summary>
        /// Возвращает и задает год выхода фильма. Должна быть не меньше 1900 и не больше нынешнего года.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает продолжительность фильма в минутах. Должна быть положительным числом.
        /// </summary>
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="durationMinutes">Продолжительность фильма в минутах.</param>
        /// <param name="releaseYear">Год выхода фильма.</param>
        /// <param name="rating">Рейтинг фильма.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="title">Название фильма.</param>
        public Movie(int durationMinutes, int releaseYear, double rating, string genre, string title)
        {
            DurationMinutes = durationMinutes; 
            ReleaseYear = releaseYear;
            Rating = rating;
            Genre = genre;
            Title = title;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Movie"/>.
        /// </summary>
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
