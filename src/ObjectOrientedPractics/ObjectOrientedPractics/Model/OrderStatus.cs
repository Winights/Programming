using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о состоянии заказа.
    /// </summary>
    public enum OrderStatus
    {
        New,
        Processing, 
        Assembly,
        Sent, 
        Delivered,   
        Returned,    
        Abandoned   
    }
}
