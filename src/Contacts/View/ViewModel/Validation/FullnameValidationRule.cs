using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using View.Model.Services;

namespace View.ViewModel.Validation
{
    /// <summary>
    /// Реализует логику валидации для имени контакта.
    /// </summary>
    public class FullnameValidationRule : ValidationRule
    {
        /// <summary>
        /// Выполняет проверку значений.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="cultureInfo">Культура, используемая в этом правиле.</param>
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string pattern = ValueValidator.GetNamePattern();

            if (string.IsNullOrWhiteSpace(value.ToString()))
            {
                return new ValidationResult(false, "Fullname must not null");
            }

            if (!Regex.IsMatch(value.ToString(), pattern))
            {
                return new ValidationResult(false, "Fullname must not consist of numbers or symbols");
            }

            if ((value.ToString()).Length > 100)
            {
                return new ValidationResult(false, "Fullname must not exceed 100 characters");
            }

            return ValidationResult.ValidResult;
        }
    }
}
