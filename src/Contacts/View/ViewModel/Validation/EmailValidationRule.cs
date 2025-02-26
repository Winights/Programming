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
    /// Реализует логику валидации для электронной почты.
    /// </summary>
    public class EmailValidationRule : ValidationRule
    {
        /// <summary>
        /// Выполняет проверку значений.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="cultureInfo">Культура, используемая в этом правиле.</param>
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string patternOfEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(value.ToString(), patternOfEmail))
            {
                return new ValidationResult(false, "Incorrect email format");
            }
            else
            {
                return ValidationResult.ValidResult;
            }
        }
    }
}
