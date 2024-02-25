using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private string _destination;
        private string _destinationName;
        private int _flightTimeMinutes;
        public string DestinationName { get { return _destinationName; } set { _destinationName = value; } }
        public string Destination { get { return _destination; } set { _destination = value; } }

        public void SetFlightTimeMinutes(int flightTimeMinutes)
        {
            if (flightTimeMinutes < 0)
            {
                throw new ArgumentException("Не может быть отрицательным числом");
            }
            _flightTimeMinutes  = flightTimeMinutes;
        }
        public int GetFlightTimeMinutes()
        {
            return _flightTimeMinutes;
        }
            
    }
}
