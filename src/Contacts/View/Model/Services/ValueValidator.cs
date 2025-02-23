using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace View.Model.Services
{
    public class ValueValidator
    {
        /// <summary>
        /// Проверяет, что строка не больше заданного числа.
        /// </summary>
        /// <param name="value">Проверямая строка.</param>
        /// <param name="max">Верхняя граница.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        public static void AssertStringOnLength(string value, int max, string propertyName)
        {
            if (value.Length > max)
            {
                throw new ArgumentOutOfRangeException($"Ошибка в {propertyName}");
            }
        }

        /// <summary>
        /// Проверяет, что строка по формату является номером телефона.
        /// </summary>
        /// <param name="value">Проверямая строка.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        public static void AssertStringOnPhoneNumber(string value, string propertyName)
        {
            string patternOfNumber = @"^(\+7|8)?[\s\-]?\(?\d{3}\)?[\s\-]?\d{3}[\s\-]?\d{2}[\s\-]?\d{2}$";
            if (!Regex.IsMatch(value, patternOfNumber))
            {
                throw new ArgumentOutOfRangeException($"Ошибка в {propertyName}");
            }
        }

        /// <summary>
        /// Проверяет, что строка по формату является электронной почтой.
        /// </summary>
        /// <param name="value">Проверямая строка.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        public static void AssertStringOnPhoneEmail(string value, string propertyName)
        {
            string patternOfEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(value, patternOfEmail))
            {
                throw new ArgumentOutOfRangeException($"Ошибка в {propertyName}");
            }
        }
    }
}
