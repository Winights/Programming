using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит количество накопленных баллов.
    /// </summary>
    public class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Накопительные баллы.
        /// </summary>
        private int _points;

        /// <summary>
        /// Максимальная скидка.
        /// </summary>
        private const double _maxDiscountPercentage = 0.3;

        /// <summary>
        /// Возвращает и задает баллы. Должен быть положительным числом.
        /// </summary>
        public int Points
        {
            get
            {
                return _points;
            }
            private set
            {
                ValueValidator.AssertOnPositiveValue(value, "Discount");
                _points = value;
            }
        }

        /// <summary>
        /// Расчет скидки для товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки</returns>
        public double Calculate(List<Item> items)
        {
            double totalCost = 0;

            foreach (var item in items)
            {
                totalCost += item.Cost;
            }

            double maxDiscount = totalCost * _maxDiscountPercentage;

            return Math.Min(Points, maxDiscount);
        }

        /// <summary>
        /// Списывает накопительные баллы.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки</returns>
        public double Apply(List<Item> items)
        {

            double discount = Calculate(items);
            // Списываем баллы
            Points -= (int)Math.Floor(discount);
            return discount;
        }

        /// <summary>
        /// Обновляет баллы.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double totalCost = 0;

            foreach (var item in items)
            {
                totalCost += item.Cost;
            }

            int earnedPoints = (int)Math.Ceiling(totalCost * 0.10); // 10% от стоимости, округление вверх
            Points += earnedPoints;
        }

        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная – {Points} баллов";
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PointsDiscount"/>.
        /// </summary>
        /// <param name="initialPoints">Накопленные баллы.</param>
        public PointsDiscount(int initialPoints)
        {
            Points = initialPoints;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="PointsDiscount"/>.
        /// </summary>
        public PointsDiscount()
        {
            Points = 0;
        }
    }
}
