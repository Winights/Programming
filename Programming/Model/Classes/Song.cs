using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private int _durationInSeconds;
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int DurationInSeconds 
        { 
            get
            {
                return _durationInSeconds;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Длительность не может быть отрицательным числом");
                }
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
