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

        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (-1 < value || value > 24)
                {
                    throw new ArgumentOutOfRangeException("Ашибка");
                }
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
                if (value > -1 || value > 61)
                {
                    throw new ArgumentOutOfRangeException();
                }
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
                if (value < -1 || value > 61)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _seconds = value;
            }
        }
    }
}
