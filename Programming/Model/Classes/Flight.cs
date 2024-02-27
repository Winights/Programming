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
        public string DestinationName { get; set; }
        public string Destination { get; set; }

        public int FlightTimeMinutes
        {
            get
            {
                return _flightTimeMinutes;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Не может быть отрицательным числом");
                }
                _flightTimeMinutes = value;
            }
        }

        public Flight(string destination, string destinationName, int flightTimeMinutes)
        {
            Destination = destination;
            DestinationName = destinationName;
            FlightTimeMinutes = flightTimeMinutes;
        }
        public Flight()
        {
            Destination = "";
            DestinationName = "";
            FlightTimeMinutes = 0;
        }
    }
}
