using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Часы для всех объектов данного класса.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Минуты для всех объектов данного класса.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Секунды для всех объектов данного класса.
        /// </summary>
        private int _seconds;

        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 23, "Hours");
                _hours = value;
            }
        }
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, "Minutes");
                _minutes = value;
            } 
        }
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, "Seconds");
                _seconds = value;
            }
        }
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Time()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }
    }
}
