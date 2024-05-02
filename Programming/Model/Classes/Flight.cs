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
        /// Время полета в минутах.
        /// </summary>
        private int _flightTimeMinutes;

        /// <summary>
        /// Возвращает и задает пункт вылета.
        /// </summary>
        public string DestinationName { get; set; }

        /// <summary>
        /// Возвращает и задает пункт назначения.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задает время полета в минутах. Должно быть положительным числом.
        /// </summary>
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="destination">Пункт назначения.</param>
        /// <param name="destinationName">Пункт вылета.</param>
        /// <param name="flightTimeMinutes">Время полета в минутах.</param>
        public Flight(string destination, string destinationName, int flightTimeMinutes)
        {
            Destination = destination;
            DestinationName = destinationName;
            FlightTimeMinutes = flightTimeMinutes;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {
            Destination = "";
            DestinationName = "";
            FlightTimeMinutes = 0;
        }
    }
}
