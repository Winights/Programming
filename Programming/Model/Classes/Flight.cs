using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о рейсах.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Время полета в минутах для всех объектов данного класса.
        /// </summary>
        private int _flightTimeMinutes;

        /// <summary>
        /// Пункт вылета для всех объектов данного класса.
        /// </summary>
        public string DestinationName { get; set; }

        /// <summary>
        /// Пункт назначения для всех объектов данного класса.
        /// </summary>
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
