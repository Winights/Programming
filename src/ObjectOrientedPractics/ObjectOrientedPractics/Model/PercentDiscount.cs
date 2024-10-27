using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит процентную скидку.
    /// </summary>
    public class PercentDiscount
    {
        /// <summary>
        /// Скидка в процентах.
        /// </summary>
        private int _percent;

        /// <summary>
        /// Возвращает скидочную категорию.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и задает скидку в процентах.
        /// </summary>
        public int Percent
        {
            get
            { 
                return _percent; 
            }
            private set
            {
                ValueValidator.AssertValueInRange(value, 1, 10, "Percent");
                _percent = value;
            }
        }

        /// <summary>
        /// Возвращает и задает сумму которую потратил покупатель в данной категории.
        /// </summary>
        public double SpendingPerCategory { get; private set; } = 0;

        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная \"{Category}\" - {Percent}%";
            }
        }

        /// <summary>
        /// Расчет скидки для товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки</returns>
        public double Calculate(List<Item> items)
        {
            double totalCost = 0;
            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    totalCost += item.Cost;
                }
            }
            return totalCost * Percent / 100;
        }

        /// <summary>
        /// Применяет скидку, доступную для списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Обновляет процент скидки на основе полученного списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double totalCost = 0;
            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    totalCost += item.Cost;
                }
            }

            SpendingPerCategory += totalCost;
            var percentage = (int)(SpendingPerCategory / 1000) + 1;
            Percent = Math.Min(percentage, 10);
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="initialPoints">Накопленные баллы.</param>
        public PercentDiscount(Category category) 
        {
            Category = category;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        public PercentDiscount()
        {
            Category = Category.Medicine;
        }
    }
}
