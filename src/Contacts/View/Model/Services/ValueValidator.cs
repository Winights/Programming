using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace View.Model.Services
{
    /// <summary>
    /// Реализирует валидацию значений.
    /// </summary>
    public static class ValueValidator
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
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException($"Ошибка в {propertyName}");
            }
        }

        /// <summary>
        /// Возвращает строку с форматом для номера телефона.
        /// </summary>
        /// <returns>Возвращает строку с шаблон для номера телефона.</returns>
        public static string GetPhoneNumberPattern()
        {
            return @"^(\+7|8)?[\s\-]?\(?\d{3}\)?[\s\-]?\d{3}[\s\-]?\d{2}[\s\-]?\d{2}$";
        }

        /// <summary>
        /// Проверяет, что строка по формату является номером телефона.
        /// </summary>
        /// <param name="value">Проверямая строка.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <example>
        /// Примеры допустимых форматов:
        /// +7 (123) 456-78-90  
        /// 8-912-234-56-77  
        /// +7 888 900 12 33
        /// 89992341266
        /// 9998976543
        /// (123) 456 78 90
        /// </example>
        public static void AssertStringOnPhoneNumber(string value, string propertyName)
        {
            string pattern = GetPhoneNumberPattern();
            if (!Regex.IsMatch(value, pattern))
            {
                throw new ArgumentException($"Ошибка в {propertyName}");
            }
        }

        /// <summary>
        /// Возвращает строку с форматом для почты.
        /// </summary>
        /// <returns>Возвращает строку с шаблон для почты.</returns>
        public static string GetEmailPattern()
        {
            return @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        }

        /// <summary>
        /// Проверяет, что строка по формату является электронной почтой.
        /// </summary>
        /// <param name="value">Проверямая строка.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <example>
        /// Примеры допустимых форматов:
        /// user@example.com
        /// john.doe123 @gmail.com
        /// contact_us @company.co.uk
        /// my-email+filter @sub.domain.org
        /// 123user @test.net
        /// first.last @university.edu
        /// name @xn--d1acpjx3f.xn--p1ai
        /// </example>
        public static void AssertStringOnEmail(string value, string propertyName)
        {
            string pattern = GetEmailPattern();
            if (!Regex.IsMatch(value, pattern))
            {
                throw new ArgumentException($"Ошибка в {propertyName}");
            }
        }

        /// <summary>
        /// Возвращает строку с форматом для имени.
        /// </summary>
        /// <returns>Возвращает строку с шаблон для имени.</returns>
        public static string GetNamePattern()
        {
            return @"^[a-zA-Zа-яА-Я\s]+$";
        }

        /// <summary>
        /// Проверяет, что строка содержит только буквы.
        /// </summary>
        /// <param name="value">Проверямое строка.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <example>
        /// Примеры допустимых форматов:
        /// Petrov Petr Petrovich
        /// Иванов Иван Иванович
        /// </example>
        public static void AssertStringOnName(string value, string propertyName)
        {
            string pattern = GetNamePattern();
            if (!Regex.IsMatch(value, pattern))
            {
                throw new ArgumentException($"Ошибка в {propertyName}");
            }
        }
    }
}
