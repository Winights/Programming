using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о корзине покупателя.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items { get { return _items; } set { _items = value; } }

        /// <summary>
        /// Возвращает стоимость всех товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                if (_items.Count == 0 || _items == null)
                {
                    return 0.0;
                }
                else
                {
                    double amount = 0.0;
                    foreach (Item item in _items)
                    {
                        amount += item.Cost;
                    }
                    return amount;
                }
            }
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }

    }
}
