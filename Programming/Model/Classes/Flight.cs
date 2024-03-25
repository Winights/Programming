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
                Validator.AssertOnPositiveValue(value, "FlightTimeMinutes");
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
