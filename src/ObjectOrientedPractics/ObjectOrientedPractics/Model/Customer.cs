using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Уникальный номер покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname = string.Empty;

        /// <summary>
        /// Адрес доставки для покупателя.
        /// </summary>
        private string _address = string.Empty;

        /// <summary>
        /// Возвращает уникальный номер покупателя.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает и задает полное имя покупателя. Должен не превышать 200 символов.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueGenerator.AssertStringOnLength(value, 200, "Fullname");
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адреса для доставки. Должен не превышать 500 символов.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                ValueGenerator.AssertStringOnLength(value, 500, "Address");
                _address = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="address">Адрес доставки для покупателя.</param>
        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Customer()
        {
            Fullname = string.Empty;
            Address = string.Empty;
            _id = IdGenerator.GetNextId();
        }
    }
}
