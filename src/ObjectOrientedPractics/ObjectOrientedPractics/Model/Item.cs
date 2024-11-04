using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товарах.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        /// <summary>
        /// Уникальный номер товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name = string.Empty;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info = string.Empty;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает уникальный номер товара.
        /// </summary>
        public int Id { get { return _id; } }


        /// <summary>
        /// Возвращает и задает название товара. Должен не превышать 200 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "Name");
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает описание товара. Должен не превышать 1000 символов.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, "Info");
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара. Должен не превышать 100000 символов.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                ValueValidator.AssertValueInRange(value, 0, 100000, "Cost");
                _cost = value;
            }
        }

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Стоимость товара.</param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = IdGenerator.GetNextId();
            Category = new Category();
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            Name = string.Empty;
            Info = string.Empty;
            Cost = 0;
            _id = IdGenerator.GetNextId();
            Category = new Category();
        }


        /// <summary>
        /// Создают копию класса <see cref="Item"/>..
        /// </summary>
        /// <returns>Копия объекта.</returns>
        public object Clone()
        {
            return new Item
            {
                Name = Name,
                Info = Info,
                Cost = Cost,
                Category = Category,
            };
        }

        /// <summary>
        /// Проверка на равенство объекта с передаваемым.
        /// </summary>
        /// <param name="subject">Объект класса.</param>
        /// <returns>Равны ли объекты.</returns>
        public bool Equals(Item subject)
        {
            if (subject == null)
            {
                return false;
            }

            if (ReferenceEquals(this, subject))
            {
                return true;
            }

            return 
                Name == subject.Name &&
                Cost == subject.Cost &&
                Info == subject.Info &&
                Category == subject.Category;
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

            return Equals((Item) subject);
        }


        /// <summary>
        /// Сравнивает цену.
        /// </summary>
        /// <param name="subject">Объект класса <see cref="Item"/>.</param>
        /// <returns>0 - цены равны, 1 - цена меньше, -1 - цена больше.</returns>
        public int CompareTo(Item subject)
        {
            if (subject == null)
            {
                return 1;
            }

            if (ReferenceEquals(this, subject))
            {
                return 0;
            }

            else
            {
                return _cost.CompareTo(subject.Cost);
            }
        }
    }
}
