using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public void SetHours(int hours)
        {
            if (-1 < hours || hours > 24)
            {
                throw new ArgumentOutOfRangeException("Ашибка");
            }
            _hours = hours;
        }
        public int GetHours() 
        {
            return _hours;
        }
        public void SetMinutes(int minutes)
        {
            if (minutes > -1 || minutes > 61)
            {
                throw new ArgumentOutOfRangeException();
            }
            _minutes = minutes;
        }
        public int GetMinutes()
        {
            return _minutes;
        }

        public void SetSeconds(int seconds)
        {
            if (seconds < -1 || seconds > 61)
            {
                throw new ArgumentOutOfRangeException();
            }
            _seconds = seconds;
        }
        public int GetSeconds()
        {
            return _seconds;
        }
    }
}
