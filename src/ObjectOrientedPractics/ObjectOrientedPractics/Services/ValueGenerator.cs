﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Реализует статистическую проверку данных.
    /// </summary>
    public class ValueGenerator
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
        /// Проверяет, что число входит в диапазон.
        /// </summary>
        /// <param name="value">Проверямое число.</param>
        /// <param name="min">Нижняя граница.</param>
        /// <param name="max">Верхняя граница.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        public static void AssertValueInRange(double value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentOutOfRangeException($"Ошибка в {propertyName}");
            }
        }
    }
}
