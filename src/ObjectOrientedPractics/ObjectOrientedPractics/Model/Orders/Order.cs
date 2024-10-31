using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Хранит данные о заказе.
    /// </summary>
    public class Order : IEquatable<Order>
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
        public string CustomerFullName { get; set; }

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
        /// Возвращает и задает скидку на товары.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Возращает стоимость заказа со скидкой.
        /// </summary>
        public double Total
        {
            get
            {
                return Amount - DiscountAmount;
            }
        }

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
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Адрес доставки для покупателя.</param>
        /// <param name="items">Список товаров.</param>
        /// /// <param name="fullname">Полное имя покупателя.</param>
        public Order(Address address, List<Item> items, string fullname, double discountAmount)
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            Address = address;
            foreach (Item item in items)
            {
                Items.Add(item);
            }
            OrderStatus = new OrderStatus();
            CustomerFullName = fullname;
            DiscountAmount = discountAmount;

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
            OrderStatus = new OrderStatus();
            CustomerFullName = string.Empty;
            DiscountAmount = 0;
        }

        /// <summary>
        /// Проверка на равенство объекта с передаваемым.
        /// </summary>
        /// <param name="subject">Объект класса.</param>
        /// <returns>Равны ли объекты.</returns>
        public bool Equals(Order subject)
        {
            if (subject == null)
            {
                return false;
            }

            if (ReferenceEquals(this, subject))
            {
                return true;
            }

            if (!Items.SequenceEqual(subject.Items))
            {
                return false;
            }

            return
                Address == subject.Address &&
                OrderStatus == subject.OrderStatus &&
                CustomerFullName == subject.CustomerFullName &&
                Amount == subject.Amount;
        }

        /// <summary>
        /// Проверка на равенство объекта с передаваемым.
        /// </summary>
        /// <param name="subject">Объект класса.</param>
        /// <returns>Равны ли объекты.</returns>
        public override bool Equals(object subject)
        {
            if (subject == null)
            {
                return false;
            }

            if (ReferenceEquals(this, subject))
            {
                return true;
            }

            return Equals((Order)subject);
        }
    }
}
