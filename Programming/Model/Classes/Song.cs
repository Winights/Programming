using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песнях в плеере.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Продолжительность песни в секундах.
        /// </summary>
        private int _durationInSeconds;

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задает исполнителя песни.
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Возвращает и задает жанр песни.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность песни в секундах. Должна быть положительным числом.
        /// </summary>
        public int DurationInSeconds 
        { 
            get
            {
                return _durationInSeconds;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "DurationInSeconds");
                _durationInSeconds = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="title">Название песни.</param>
        /// <param name="artist">Исполнитель песни.</param>
        /// <param name="durationInSeconds">Продолжительность песни в секундах.</param>
        /// <param name="genre">Жанр песни.</param>
        public Song(string title, string artist, int durationInSeconds, string genre)
        {
            Title = title;
            Artist = artist;
            DurationInSeconds = durationInSeconds;
            Genre = genre;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {
            Title = "";
            Artist = "";
            DurationInSeconds = 0;
            Genre = "";
        }
    }
}
