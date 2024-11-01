﻿using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Discounts;
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
    public class Customer
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
                ValueValidator.AssertStringOnLength(value, 200, "Fullname");
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// </summary>
        public Address CustomerAddress { get; set; }

        /// <summary>
        /// Возвращает и задает корзину покупателя.
        /// </summary>
        public Cart CustomerCart { get; set; }

        /// <summary>
        /// Возвращает и задает список заказов покупателя.
        /// </summary>
        public List<Order> Orders { get; set; }

        /// <summary>
        /// Возвращает и задает булево значение о том, является ли покупатель приоритетным.
        /// </summary>
        public bool IsPriority { get; set; } = false;

        /// <summary>
        /// Возвращает и задает список скидок покупателя.
        /// </summary>
        public List<IDiscount> Discounts { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        public Customer(string fullname)
        {
            Fullname = fullname;
            CustomerAddress = new Address();
            _id = IdGenerator.GetNextId();
            CustomerCart = new Cart();
            Orders = new List<Order>();
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            Fullname = string.Empty;
            CustomerAddress = new Address();
            _id = IdGenerator.GetNextId();
            CustomerCart = new Cart();
            Orders = new List<Order>();
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }
    }
}
