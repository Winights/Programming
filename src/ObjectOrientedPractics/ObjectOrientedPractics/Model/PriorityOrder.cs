using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о приоритетном заказе.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Возвращает и задает дату доставки.
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Возвращает и задает время доставки.
        /// </summary>
        public DeliveryTime DesiredDeliveryTime { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="deliveryAddress">Адрес доставки.</param>
        /// <param name="customerName">Имя покупателя.</param>
        /// <param name="desiredDeliveryTime">Время доставки.</param>
        /// <param name="deliveryDate">Дата доставки.</param>
        public PriorityOrder(List<Item> items, Address deliveryAddress, 
            string customerName, DeliveryTime 
            desiredDeliveryTime, DateTime deliveryDate) : base(deliveryAddress, items,
                customerName)
        {
            DesiredDeliveryTime = desiredDeliveryTime;
            DeliveryDate = deliveryDate;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder() : base()
        {
            DesiredDeliveryTime = DeliveryTime.Morning;
            DeliveryDate = DateTime.Now;
        }
    }
}
