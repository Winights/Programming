using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит время доставки товара.
    /// </summary>
    public enum DeliveryTime
    {
        /// <summary>
        /// 9:00 - 11:00
        /// </summary>
        Morning = 1,

        /// <summary>
        /// 11:00 - 13:00
        /// </summary>
        Lunch = 2,

        /// <summary>
        /// 13:00 - 15:00
        /// </summary>
        Afternoon = 3,

        /// <summary>
        /// 15:00 - 17:00
        /// </summary>
        Evening = 4,

        /// <summary>
        /// 17:00 - 19:00
        /// </summary>
        LateEvening = 5,

        /// <summary>
        /// 19:00 - 21:00
        /// </summary>
        Night = 6
    }
}
