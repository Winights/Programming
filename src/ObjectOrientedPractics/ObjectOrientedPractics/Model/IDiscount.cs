using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Интерфейс скидок.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        string Info {  get; }

        /// <summary>
        /// Расчет скидки для товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку, доступную для списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет процент скидки на основе полученного списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        void Update(List<Item> items);
    }
}
