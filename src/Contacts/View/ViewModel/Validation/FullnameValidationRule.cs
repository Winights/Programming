using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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
            if ((value.ToString()).Length > 100)
            {
                return new ValidationResult(false, "Fullname must not exceed 100 characters");
            }

            if (value == string.Empty)
            {
                return new ValidationResult(false, "Fullname must not null");
            }

            return ValidationResult.ValidResult;
        }
    }
}
