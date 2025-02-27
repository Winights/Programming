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
        /// <param name="cultureInfo">Сведения об определенном языке и региональных параметрах, 
        /// используемые в этом правиле.</param>
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string patternOfEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (value.ToString() == string.Empty)
            {
                return new ValidationResult(false, "Email must not null");
            }

            if (!Regex.IsMatch(value.ToString(), patternOfEmail))
            {
                return new ValidationResult(false, "Incorrect email format");
            }

            if ((value.ToString()).Length > 100)
            {
                return new ValidationResult(false, "Email is too long");
            }

            if ((value.ToString()).Length < 6)
            {
                return new ValidationResult(false, "Email is too short");
            }

            return ValidationResult.ValidResult;
        }
    }
}
