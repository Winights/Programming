using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace View.Model.Services
{
    /// <summary>
    /// Реализирует форматирования номера телефона.
    /// </summary>
    public static class PhoneNumberFormatter
    {
        /// <summary>
        /// Форматирует номер телефона в определенный формат.
        /// </summary>
        /// <param name="value">Строка, содержащая номер телефона.</param>
        /// <returns> Возвращает строку с отформатированым номером телефона.</returns>
        public static string FormatPhoneNumber(string value)
        {
            string digits = new string(value.Where(char.IsDigit).ToArray());
            if (digits.Length == 11)
            {
                return $"+7 ({digits.Substring(1, 3)}) {digits.Substring(3, 3)}-" +
                $"{digits.Substring(6, 2)}-{digits.Substring(8, 2)}";
            }
            if (digits.Length == 10)
            {
                return $"+7 ({digits.Substring(0, 3)}) {digits.Substring(3, 3)}-" +
                $"{digits.Substring(6, 2)}-{digits.Substring(8, 2)}";
            }
            else
            {
                throw new FormatException("Incorrect phone number");
            }
        }
    }
}
