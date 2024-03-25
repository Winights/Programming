using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class Validator
    {
       public static void AssertOnPositiveValue(int value, string Name)
       {
            if (value < 0)
            {
                throw new ArgumentException($"Число не может быть отрицательным. Ошибка в свойстве {Name}");
            }
       }
        public static void AssertOnPositiveValue(double value, string Name)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Число не может быть отрицательным. Ошибка в свойстве {Name}");
            }
        }
        public static void AssertValueInRange(int value, int min, int max, string Name)
        {
            if (value < min || value > max)
            {
                throw new ArgumentOutOfRangeException($"Ошибка в {Name}");
            }
        }
    }
}
