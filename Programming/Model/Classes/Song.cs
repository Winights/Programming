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
        /// Продолжительность песни в секундах для всех объектов данного класса.
        /// </summary>
        private int _durationInSeconds;

        /// <summary>
        /// Название песни для всех объектов данного класса.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Исполнитель песни для всех объектов данного класса.
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Жанр песни для всех объектов данного класса.
        /// </summary>
        public string Genre { get; set; }
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
        public Song(string title, string artist, int durationInSeconds, string genre)
        {
            Title = title;
            Artist = artist;
            DurationInSeconds = durationInSeconds;
            Genre = genre;
        }
        public Song()
        {
            Title = "";
            Artist = "";
            DurationInSeconds = 0;
            Genre = "";
        }
    }
}
