using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о корзине покупателя.
    /// </summary>
    public class Cart : ICloneable
    {
        /// <summary>
        /// Возвращает и задает cписок товаров в корзине.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

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
        /// Создаёт пустой экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }

        /// <summary>
        /// Создают копию класса <see cref="Cart"/>..
        /// </summary>
        /// <returns>Копия объекта.</returns>
        public object Clone()
        {
            var cartClone = new Cart();
            foreach (Item item in Items)
            {
                cartClone.Items.Add((Item)item.Clone());
            }

            return cartClone;
        
        }
    }
}
