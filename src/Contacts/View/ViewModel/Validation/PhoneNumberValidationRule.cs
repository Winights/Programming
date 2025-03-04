using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace View.ViewModel.Validation
{
    /// <summary>
    /// Реализует логику валидации для номера телефона.
    /// </summary>
    public class PhoneNumberValidationRule : ValidationRule
    {
        /// <summary>
        /// Выполняет проверку значений.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="cultureInfo">Культура, используемая в этом правиле.</param>
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string patternOfNumber = @"^(\+7|8)[\s\-]?\(?\d{3}\)?[\s\-]?\d{3}[\s\-]?\d{2}[\s\-]?\d{2}$";

            if (value.ToString() == string.Empty) 
            {
                return new ValidationResult(false, "Phone number  must not null");
            }

            if (!Regex.IsMatch(value.ToString(), patternOfNumber))
            {
                return new ValidationResult(false, "Incorrect phone number format");
            }

            return ValidationResult.ValidResult;
        }
    }
}
