﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingSolution.ModelSolution
{
    /// <summary>
    /// Реализует статистическую проверку данных.
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// Проверяет, что число является положительным.
        /// </summary>
        /// <param name="value">Проверямое число.</param>
        /// <param name="Name">Имя свойства или объекта, которое подлежит проверке.</param>
        public static void AssertOnPositiveValue(int value, string Name)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Число не может быть отрицательным. Ошибка в свойстве {Name}");
            }
        }

        public static void AssertStringLength(string value, int max, string Name)
        {
            if (value.Length > max)
            {
                throw new ArgumentException($"Превысило {max} символов. Ошибка в {Name}");
            }
        }

        /// <summary>
        /// Проверяет, что число входит в диапазон.
        /// </summary>
        /// <param name="value">Проверямое число.</param>
        /// <param name="max">Максимальная граница.</param>
        /// <param name="Name">Имя свойства или объекта, которое подлежит проверке.</param>
        public static void AssertValueInRange(double value, int min, int max, string Name)
        {
            if (value < min || value > max)
            {
                throw new ArgumentOutOfRangeException($"Ошибка в {Name}");
            }
        }
    }
}
