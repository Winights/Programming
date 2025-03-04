using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace View.Model.Services
{
    /// <summary>
    /// Реализирует валидацию значений.
    /// </summary>
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
        /// Проверяет, что строка не пустая.
        /// </summary>
        /// <param name="value">Проверямая строка.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        public static void AssertStringOnEmpty(string value, string propertyName)
        {
            if (value == string.Empty)
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
        public static void AssertStringOnEmail(string value, string propertyName)
        {
            string patternOfEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(value, patternOfEmail))
            {
                throw new ArgumentOutOfRangeException($"Ошибка в {propertyName}");
            }
        }

        /// <summary>
        /// Проверяет, что длина строки входит в диапозон входит в диапазон.
        /// </summary>
        /// <param name="value">Проверямое строка.</param>
        /// <param name="min">Нижняя граница.</param>
        /// <param name="max">Верхняя граница.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        public static void AssertStringInRange(string value, int min, int max, string propertyName)
        {
            if (value.Length < min || value.Length > max)
            {
                throw new ArgumentOutOfRangeException($"Ошибка в {propertyName}");
            }
        }
    }
}
