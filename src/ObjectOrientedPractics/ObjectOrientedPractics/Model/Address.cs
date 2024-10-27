using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные об адресе.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна или регион.
        /// </summary>
        private string _country = string.Empty;

        /// <summary>
        /// Город(населенный пункт).
        /// </summary>
        private string _city = string.Empty;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street = string.Empty;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building = string.Empty;

        /// <summary>
        /// Номер квартиры или помещения.
        /// </summary>
        private string _apartment = string.Empty;

        /// <summary>
        /// Возвращает и задает почтовый индекс. Должен быть шестизначным числом.
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                ValueValidator.AssertValueInRange(value, 100000, 999999, "Index");
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задает страну или регион. Строка должна быть не более 50 символов.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "Country");
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задает город(населенный пункт). Строка должна быть не более 50 символов.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "City");
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задает улицу. Строка должна быть не более 100 символов.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, "Street");
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер дома. Строка должна быть не более 10 символов.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "Street");
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры или помещения. Строка должна быть не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "Street");
                _apartment = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна или регион.</param>
        /// <param name="city">Город(населенный пункт).</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер кватиры или помещения.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = string.Empty;
            City = string.Empty;
            Street = string.Empty;
            Building = string.Empty;
            Apartment = string.Empty;
        }
    }
}
