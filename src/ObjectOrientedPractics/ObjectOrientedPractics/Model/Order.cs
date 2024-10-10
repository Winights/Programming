using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о заказе.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный номер покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private readonly DateTime _date;

        /// <summary>
        /// Имя покупателя, сделавшего заказ.
        /// </summary>
        private string _customerFullName = string.Empty;

        /// <summary>
        /// Возвращает уникальный номер заказа.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime Date { get { return _date; } }

        /// <summary>
        /// Возвращает и задаёт имя покупателя, сделавшего заказ.
        /// </summary>
        public string CustomerFullName { get { return _customerFullName; } set { _customerFullName = value; } }

        /// <summary>
        /// Возвращает и задаёт адрес доставки.
        /// </summary>
        public Address Address { get; set; } = new Address();

        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }
        
        /// <summary>
        /// Возвращает стоимость всех товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                if (Items.Count == 0 || Items == null)
                {
                    return 0.0;
                }
                else
                {
                    double amount = 0.0;
                    foreach (Item item in Items)
                    {
                        amount += item.Cost;
                    }
                    return amount;
                }
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="address">Адрес доставки для покупателя.</param>
        /// <param name="items">Список товаров.</param>
        /// <param name="orderStatus">Статус заказа.</param>
        public Order(Address address, List<Item> items, string fullname)
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            Address = address;
            foreach(Item item in items)
            {
                Items.Add(item);
            }
            OrderStatus = 0;
            CustomerFullName = fullname;

        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            Address = new Address();
            Items = new List<Item>();
            OrderStatus = 0;
            CustomerFullName = string.Empty;
        }
    }
}
